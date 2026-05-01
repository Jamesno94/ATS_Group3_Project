using System;
using System.Data.Entity;
using System.Linq;

namespace ATS_Group3_Project
{
    public class DispatchManager
    {
        public bool CreateScheduledServiceJob(string turbineId)
        {
            using (var db = new ATSContext())
            {
                var turbine = db.Turbines
                    .Include(t => t.WindFarm)
                    .FirstOrDefault(t => t.TurbineId == turbineId);

                if (turbine == null)
                    return false;

                bool existingOpenService = db.JobRecords.Any(j =>
                    j.TurbineId == turbineId &&
                    j.JobType == "Scheduled Service" &&
                    j.JobComplete == "Awaiting Engineer");

                if (existingOpenService)
                    return false;

                DateTime targetDate = DateTime.Today.AddDays(1);

                Staff engineer = FindAvailableEngineer(db, targetDate, "Early");
                string jobTime = "Early";

                if (engineer == null)
                {
                    engineer = FindAvailableEngineer(db, targetDate, "Late");
                    jobTime = "Late";
                }

                while (engineer == null)
                {
                    targetDate = targetDate.AddDays(1);

                    engineer = FindAvailableEngineer(db, targetDate, "Early");
                    jobTime = "Early";

                    if (engineer == null)
                    {
                        engineer = FindAvailableEngineer(db, targetDate, "Late");
                        jobTime = "Late";
                    }
                }

                JobRecord job = new JobRecord
                {
                    JobDate = targetDate,
                    JobTime = jobTime,
                    FarmId = turbine.FarmId,
                    TurbineId = turbine.TurbineId,
                    StaffId = engineer.StaffId,
                    JobType = "Scheduled Service",
                    FaultDescription = null,

                    MainGeneratorServiced = false,
                    GearboxServiced = false,
                    YawMotorServiced = false,
                    InternalPassengerLiftServiced = false,

                    MainGeneratorReplaced = false,
                    GearboxReplaced = false,
                    YawMotorReplaced = false,
                    InternalPassengerLiftReplaced = false,

                    JobComplete = "Awaiting Engineer"
                };

                turbine.Status = "Requires Service";

                db.JobRecords.Add(job);
                db.SaveChanges();

                return true;
            }
        }

        public bool CreateFaultJob(string turbineId, string faultDescription, DateTime reportedDateTime)
        {
            using (var db = new ATSContext())
            {
                var turbine = db.Turbines
                    .FirstOrDefault(t => t.TurbineId == turbineId);

                if (turbine == null)
                    return false;

                DateTime targetDate;
                string preferredShift;

                if (reportedDateTime.TimeOfDay < new TimeSpan(12, 0, 0))
                {
                    targetDate = reportedDateTime.Date;
                    preferredShift = "Late";
                }
                else
                {
                    targetDate = reportedDateTime.Date.AddDays(1);
                    preferredShift = "Early";
                }

                Staff engineer = FindAvailableEngineer(db, targetDate, preferredShift);
                string jobTime = preferredShift;

                while (engineer == null)
                {
                    if (jobTime == "Late")
                    {
                        targetDate = targetDate.AddDays(1);
                        jobTime = "Early";
                    }
                    else
                    {
                        jobTime = "Late";
                    }

                    engineer = FindAvailableEngineer(db, targetDate, jobTime);
                }

                JobRecord job = new JobRecord
                {
                    JobDate = targetDate,
                    JobTime = jobTime,
                    FarmId = turbine.FarmId,
                    TurbineId = turbine.TurbineId,
                    StaffId = engineer.StaffId,
                    JobType = "Fault",
                    FaultDescription = faultDescription,

                    MainGeneratorServiced = false,
                    GearboxServiced = false,
                    YawMotorServiced = false,
                    InternalPassengerLiftServiced = false,

                    MainGeneratorReplaced = false,
                    GearboxReplaced = false,
                    YawMotorReplaced = false,
                    InternalPassengerLiftReplaced = false,

                    JobComplete = "Awaiting Engineer"
                };

                turbine.Status = "Fault";

                db.JobRecords.Add(job);
                db.SaveChanges();

                return true;
            }
        }

        private Staff FindAvailableEngineer(ATSContext db, DateTime date, string shiftType)
        {
            string dayName = date.DayOfWeek.ToString();

            var engineers = db.Staff
                .Include(s => s.EngineerShift)
                .Where(s =>
                    s.Role == "Engineer" &&
                    s.EngineerShift.ShiftType == shiftType)
                .ToList();

            foreach (var engineer in engineers)
            {
                bool worksThatDay = WorksOnDay(engineer.EngineerShift, dayName);

                bool alreadyHasJob = db.JobRecords.Any(j =>
                    j.StaffId == engineer.StaffId &&
                    DbFunctions.TruncateTime(j.JobDate) == date.Date &&
                    j.JobTime == shiftType &&
                    j.JobComplete == "Awaiting Engineer");

                if (worksThatDay && !alreadyHasJob)
                    return engineer;
            }

            return null;
        }

        private bool WorksOnDay(EngineerShift shift, string dayName)
        {
            if (dayName == "Monday") return shift.Monday;
            if (dayName == "Tuesday") return shift.Tuesday;
            if (dayName == "Wednesday") return shift.Wednesday;
            if (dayName == "Thursday") return shift.Thursday;
            if (dayName == "Friday") return shift.Friday;
            if (dayName == "Saturday") return shift.Saturday;
            if (dayName == "Sunday") return shift.Sunday;

            return false;
        }
    }
}