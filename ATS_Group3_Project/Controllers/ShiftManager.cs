using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ATS_Group3_Project
{
    public class ShiftManager
    {
        public List<EngineerShift> GetAllShifts()
        {
            using (var db = new ATSContext())
            {
                return db.EngineerShifts
                    .Include(s => s.Staff)
                    .ToList();
            }
        }

        public EngineerShift GetShiftByStaffId(string staffId)
        {
            using (var db = new ATSContext())
            {
                return db.EngineerShifts
                    .Include(s => s.Staff)
                    .FirstOrDefault(s => s.StaffId == staffId);
            }
        }

        public List<EngineerShift> GetShiftsByType(string shiftType)
        {
            using (var db = new ATSContext())
            {
                return db.EngineerShifts
                    .Include(s => s.Staff)
                    .Where(s => s.ShiftType == shiftType)
                    .ToList();
            }
        }

        public bool AddShift(EngineerShift shift)
        {
            using (var db = new ATSContext())
            {
                db.EngineerShifts.Add(shift);
                db.SaveChanges();
                return true;
            }
        }

        public bool UpdateShift(EngineerShift updatedShift)
        {
            using (var db = new ATSContext())
            {
                var shift = db.EngineerShifts.Find(updatedShift.StaffId);

                if (shift == null)
                {
                    return false;
                }

                shift.ShiftType = updatedShift.ShiftType;
                shift.Monday = updatedShift.Monday;
                shift.Tuesday = updatedShift.Tuesday;
                shift.Wednesday = updatedShift.Wednesday;
                shift.Thursday = updatedShift.Thursday;
                shift.Friday = updatedShift.Friday;
                shift.Saturday = updatedShift.Saturday;
                shift.Sunday = updatedShift.Sunday;

                db.SaveChanges();
                return true;
            }
        }

        public bool DeleteShift(string staffId)
        {
            using (var db = new ATSContext())
            {
                var shift = db.EngineerShifts.Find(staffId);

                if (shift == null)
                {
                    return false;
                }

                db.EngineerShifts.Remove(shift);
                db.SaveChanges();
                return true;
            }
        }
    }
}