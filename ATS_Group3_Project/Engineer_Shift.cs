using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATS_Group3_Project
{
    

namespace ATS_Group3_Project
    {
        internal class Engineer_Shift
        {
            public string ShiftID { get; set; }
            public string StaffID { get; set; }
            public string ShiftType { get; set; }

            public bool MonActive { get; set; }
            public bool TueActive { get; set; }
            public bool WedActive { get; set; }
            public bool ThuActive { get; set; }
            public bool FriActive { get; set; }
            public bool SatActive { get; set; }
            public bool SunActive { get; set; }

            public bool IsWorkingDay(DayOfWeek day)
            {
                switch (day)
                {
                    case DayOfWeek.Monday: return MonActive;
                    case DayOfWeek.Tuesday: return TueActive;
                    case DayOfWeek.Wednesday: return WedActive;
                    case DayOfWeek.Thursday: return ThuActive;
                    case DayOfWeek.Friday: return FriActive;
                    case DayOfWeek.Saturday: return SatActive;
                    case DayOfWeek.Sunday: return SunActive;
                    default: return false;
                }
            }

            public bool IsAvailable(DateTime date)
            {
                return IsWorkingDay(date.DayOfWeek);
            }
        }
    }
}
