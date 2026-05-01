using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text.RegularExpressions;

public class UserManager
{
    public User Login(string staffId, string password)
    {
        using (var db = new ATSContext())
        {
            var user = db.Users
                .Include(u => u.Staff)
                .FirstOrDefault(u => u.StaffId == staffId);

            if (user == null)
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
                return null;
            }

            return user;
        }
    }

    public bool CreateUser(string staffId, string password)
    {
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
                PasswordSalt = passwordResult.salt
            };

            db.Users.Add(newUser);
            db.SaveChanges();

            return true;
        }
    }

    public bool ChangePassword(int userId, string newPassword)
    {
        if (!IsPasswordComplex(newPassword))
        {
            return false;
        }

        using (var db = new ATSContext())
        {
            var user = db.Users.Find(userId);

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
}