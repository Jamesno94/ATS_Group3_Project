using System;
using System.Data.Entity;
using System.Linq;

namespace ATS_Group3_Project
{
    public class DispatchManager
    {
        public string GenerateJobId()
        {
            //using (var db = new ATSContext())
            //{
            //    string prefix = "JOB";

            //    var lastJob = db.JobRecords
            //        .Where(j => j.JobId.StartsWith(prefix + "-"))
            //        .ToList()
            //        .OrderByDescending(s => int.Parse(s.JobId.Split('-')[1]))
            //        .FirstOrDefault();

            //    int nextNumber = 9001;

            //    if (lastJob != null)
            //    {
            //        string[] parts = lastJob.JobId.Split('-');

            //        if (parts.Length == 2 &&
            //            int.TryParse(parts[1], out int number))
            //        {
            //            nextNumber = number + 1;
            //        }
            //    }

            //    return prefix + "-" + nextNumber.ToString("D4");
            //}
            using (var db = new ATSContext())
            {
                string prefix = "JOB";

                int highestNumber = db.JobRecords
                    .AsEnumerable()
                    .Select(j =>
                    {
                        string[] parts = j.JobId.Split('-');

                        if (parts.Length == 2 &&
                            int.TryParse(parts[1], out int number))
                        {
                            return number;
                        }

                        return 9000;
                    })
                    .DefaultIfEmpty(9000)
                    .Max();

                return $"{prefix}-{(highestNumber + 1):D4}";
            }
        }

        public JobRecord CreateScheduledServiceJob(string turbineId)
        {
            using (var db = new ATSContext())
            {
                var turbine = db.Turbines
                    .Include(t => t.WindFarm)
                    .FirstOrDefault(t => t.TurbineId == turbineId);

                if (turbine == null)
                    return null;

                if (turbine.RuntimeHours < 2000)
                    return null;

                bool existingOpenService = db.JobRecords.Any(j =>
                    j.TurbineId == turbineId &&
                    j.JobType == "Scheduled Service" &&
                    j.JobComplete == "Awaiting Engineer");

                if (existingOpenService)
                    return null;

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
                    JobId = GenerateJobId(),
                    JobDate = targetDate,
                    JobTime = jobTime,
                    WindFarmId = turbine.WindFarmId,
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

                return job;
            }
        }

        public JobRecord CreateFaultJob(string turbineId, string faultDescription, DateTime reportedDateTime)
        {
            using (var db = new ATSContext())
            {
                var turbine = db.Turbines
                    .Include(t => t.WindFarm)
                    .FirstOrDefault(t => t.TurbineId == turbineId);

                if (turbine == null)
                    return null;

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
                    JobId = GenerateJobId(),
                    JobDate = targetDate,
                    JobTime = jobTime,
                    WindFarmId = turbine.WindFarmId,
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

                return job;
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