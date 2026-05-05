using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ATS_Group3_Project
{
    public class StaffManager
    {
        public bool RegisterStaffAccount(string staffId, string firstName, string lastName, string workMobile, string homeMobile, string email, string address1,
                                         string address2, string city, string postcode, decimal salary, string role, string password)
        {
            using (var db = new ATSContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        if (StaffExists(staffId) || EmailExists(email))
                            return false;

                        Staff staff = new Staff
                        {
                            StaffId = staffId.Trim(),
                            FirstName = firstName.Trim(),
                            LastName = lastName.Trim(),
                            WorkMobile = workMobile.Trim(),
                            HomeMobile = homeMobile,
                            Email = email.Trim(),
                            Address1 = address1.Trim(),
                            Address2 = address2,
                            City = city.Trim(),
                            Postcode = postcode.Trim(),
                            Salary = salary,
                            Role = role
                        };

                        var passwordResult = PasswordHelper.HashPassword(password);

                        User user = new User
                        {
                            StaffId = staff.StaffId,
                            PasswordHash = passwordResult.hash,
                            PasswordSalt = passwordResult.salt
                        };

                        db.Staff.Add(staff);
                        db.Users.Add(user);
                        db.SaveChanges();

                        transaction.Commit();
                        return true;
                    }
                    catch
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }

        public bool AddStaff(Staff staff)
        {
            using (var db = new ATSContext())
            {
                if (db.Staff.Any(s => s.StaffId == staff.StaffId))
                    return false;

                db.Staff.Add(staff);
                db.SaveChanges();
                return true;
            }
        }

        public List<Staff> GetAllStaff()
        {
            using (var db = new ATSContext())
            {
                return db.Staff
                    .Include(s => s.EngineerShift)
                    .Include(s => s.Jobs)
                    .ToList();
            }
        }

        public Staff GetStaffById(string staffId)
        {
            using (var db = new ATSContext())
            {
                return db.Staff
                    .Include(s => s.EngineerShift)
                    .Include(s => s.Jobs)
                    .FirstOrDefault(s => s.StaffId == staffId);
            }
        }

        public List<Staff> GetAllEngineers()
        {
            using (var db = new ATSContext())
            {
                return db.Staff
                    .Include(s => s.EngineerShift)
                    .Where(s => s.Role == "Engineer")
                    .ToList();
            }
        }

        public List<Staff> GetAllCallHandlers()
        {
            using (var db = new ATSContext())
            {
                return db.Staff
                    .Where(s => s.Role == "Call Handler")
                    .ToList();
            }
        }

        public List<Staff> GetAllAdmins()
        {
            using (var db = new ATSContext())
            {
                return db.Staff
                    .Where(s => s.Role == "Admin")
                    .ToList();
            }
        }

        public bool UpdateStaff(Staff updatedStaff)
        {
            using (var db = new ATSContext())
            {
                var staff = db.Staff.Find(updatedStaff.StaffId);

                if (staff == null)
                    return false;

                staff.FirstName = updatedStaff.FirstName;
                staff.LastName = updatedStaff.LastName;
                staff.WorkMobile = updatedStaff.WorkMobile;
                staff.HomeMobile = updatedStaff.HomeMobile;
                staff.Email = updatedStaff.Email;
                staff.Address1 = updatedStaff.Address1;
                staff.Address2 = updatedStaff.Address2;
                staff.City = updatedStaff.City;
                staff.Postcode = updatedStaff.Postcode;
                staff.Salary = updatedStaff.Salary;
                staff.Role = updatedStaff.Role;

                db.SaveChanges();
                return true;
            }
        }

        public bool DeleteStaff(string staffId)
        {
            using (var db = new ATSContext())
            {
                var staff = db.Staff.Find(staffId);

                if (staff == null)
                    return false;

                var user = db.Users.FirstOrDefault(u => u.StaffId == staffId);

                if (user != null)
                    db.Users.Remove(user);

                db.Staff.Remove(staff);
                db.SaveChanges();

                return true;
            }
        }

        public bool StaffExists(string staffId)
        {
            using (var db = new ATSContext())
            {
                return db.Staff.Any(s => s.StaffId == staffId);
            }
        }

        public bool EmailExists(string email)
        {
            using (var db = new ATSContext())
            {
                return db.Staff.Any(s => s.Email == email);
            }
        }
    }
}