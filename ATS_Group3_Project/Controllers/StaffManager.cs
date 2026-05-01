using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ATS_Group3_Project
{
    public class StaffManager
    {
        public List<Staff> GetAllStaff()
        {
            using (var db = new ATSContext())
            {
                return db.Staff
                    .Include(s => s.EngineerShift)
                    .ToList();
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

        public Staff GetStaffById(string staffId)
        {
            using (var db = new ATSContext())
            {
                return db.Staff
                    .Include(s => s.EngineerShift)
                    .FirstOrDefault(s => s.StaffId == staffId);
            }
        }

        public bool AddStaff(Staff staff)
        {
            using (var db = new ATSContext())
            {
                db.Staff.Add(staff);
                db.SaveChanges();
                return true;
            }
        }

        public bool UpdateStaff(Staff updatedStaff)
        {
            using (var db = new ATSContext())
            {
                var staff = db.Staff.Find(updatedStaff.StaffId);

                if (staff == null)
                {
                    return false;
                }

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
                {
                    return false;
                }

                db.Staff.Remove(staff);
                db.SaveChanges();
                return true;
            }
        }
    }
}