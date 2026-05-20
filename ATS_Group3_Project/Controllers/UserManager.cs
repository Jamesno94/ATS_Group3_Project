using ATS_Group3_Project;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

public class UserManager
{
    public User Login(string staffId, string password)
    {
        staffId = staffId.Trim().ToUpper();
        password = password.Trim();

        using (var db = new ATSContext())
        {
            var user = db.Users
                .Include(u => u.Staff)
                .FirstOrDefault(u => u.StaffId == staffId);

            if (user == null)
            {
                return null;
            }

            if (user.IsLocked)
            {
                return null;
            }

            bool passwordCorrect = PasswordHelper.VerifyPassword(
                password,
                user.PasswordHash,
                user.PasswordSalt
            );

            if (!passwordCorrect)
            {
                user.FailedLoginAttempts++;

                if (user.FailedLoginAttempts >= 3)
                {
                    user.IsLocked = true;
                }

                db.SaveChanges();
                return null;
            }

            user.FailedLoginAttempts = 0;
            db.SaveChanges();

            return user;
        }
    }




    public int CountUsers()
    {
        using (var db = new ATSContext())
        {
            return db.Users.Count();
        }
    }





    public bool CreateUser(string staffId, string password)
    {
        staffId = staffId.Trim();

        if (!IsPasswordComplex(password))
        {
            return false;
        }

        using (var db = new ATSContext())
        {
            bool staffExists = db.Staff.Any(s => s.StaffId == staffId);
            bool userAlreadyExists = db.Users.Any(u => u.StaffId == staffId);

            if (!staffExists || userAlreadyExists)
            {
                return false;
            }

            var passwordResult = PasswordHelper.HashPassword(password);

            User newUser = new User
            {
                StaffId = staffId,
                PasswordHash = passwordResult.hash,
                PasswordSalt = passwordResult.salt,
                FailedLoginAttempts = 0,
                IsLocked = false
            };

            db.Users.Add(newUser);
            db.SaveChanges();

            return true;
        }
    }

    public bool ChangePassword(string staffId, string newPassword)
    {
        if (!IsPasswordComplex(newPassword))
        {
            return false;
        }

        using (var db = new ATSContext())
        {
            var user = db.Users.Find(staffId);

            if (user == null)
            {
                return false;
            }

            var passwordResult = PasswordHelper.HashPassword(newPassword);

            user.PasswordHash = passwordResult.hash;
            user.PasswordSalt = passwordResult.salt;

            db.SaveChanges();
            return true;
        }
    }

    public List<User> GetAllUsers()
    {
        using (var db = new ATSContext())
        {
            return db.Users
                .Include(u => u.Staff)
                .ToList();
        }
    }

    private bool IsPasswordComplex(string password)
    {
        if (string.IsNullOrWhiteSpace(password))
        {
            return false;
        }

        bool hasMinimumLength = password.Length >= 8;
        bool hasUppercase = Regex.IsMatch(password, "[A-Z]");
        bool hasNumber = Regex.IsMatch(password, "[0-9]");

        return hasMinimumLength && hasUppercase && hasNumber;
    }

    public bool UnlockUser(string staffId)
    {
        using (var db = new ATSContext())
        {
            var user = db.Users.FirstOrDefault(u => u.StaffId == staffId);

            if (user == null)
                return false;

            user.IsLocked = false;
            user.FailedLoginAttempts = 0;

            db.SaveChanges();
            return true;
        }
    }
    public bool IsUserLocked(string staffId)
    {
        using (var db = new ATSContext())
        {
            var user = db.Users.FirstOrDefault(u => u.StaffId == staffId);

            if (user == null)
                return false;

            return user.IsLocked;
        }
    }
    public bool GeneratePasswordResetCode(string staffId, out string message)
    {
        message = "";

        using (var db = new ATSContext())
        {
            var user = db.Users
                .Include(u => u.Staff)
                .FirstOrDefault(u => u.StaffId == staffId);

            if (user == null)
            {
                message = "If the account exists, a reset code has been sent.";
                return true;
            }

            Random random = new Random();
            string code = random.Next(100000, 999999).ToString();

            user.PasswordResetCode = code;
            user.PasswordResetExpiry = DateTime.Now.AddMinutes(15);

            db.SaveChanges();

            EmailManager emailManager = new EmailManager();

            emailManager.SendPasswordResetEmail(
                user.Staff.Email,
                user.Staff.FirstName,
                code
            );

            message = "If the account exists, a reset code has been sent.";
            return true;
        }
    }
    public bool ResetPassword(string staffId, string code, string newPassword, out string message)
    {
        message = "";

        if (!IsPasswordComplex(newPassword))
        {
            message = "Password must be at least 8 characters and contain an uppercase letter and a number.";
            return false;
        }

        using (var db = new ATSContext())
        {
            var user = db.Users.FirstOrDefault(u => u.StaffId == staffId);

            if (user == null)
            {
                message = "Invalid reset request.";
                return false;
            }

            if (user.PasswordResetCode != code)
            {
                message = "Invalid reset code.";
                return false;
            }

            if (user.PasswordResetExpiry == null || user.PasswordResetExpiry < DateTime.Now)
            {
                message = "Reset code has expired.";
                return false;
            }

            var password = PasswordHelper.HashPassword(newPassword);

            user.PasswordHash = password.hash;
            user.PasswordSalt = password.salt;

            user.PasswordResetCode = null;
            user.PasswordResetExpiry = null;

            user.FailedLoginAttempts = 0;
            user.IsLocked = false;

            db.SaveChanges();

            message = "Password reset successfully.";
            return true;
        }
    }
}