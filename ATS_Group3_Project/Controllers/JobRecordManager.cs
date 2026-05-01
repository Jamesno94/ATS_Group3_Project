using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ATS_Group3_Project
{
    public class JobRecordManager
    {
        public List<JobRecord> GetAllJobs()
        {
            using (var db = new ATSContext())
            {
                return db.JobRecords
                    .Include(j => j.WindFarm)
                    .Include(j => j.Turbine)
                    .Include(j => j.Staff)
                    .ToList();
            }
        }

        public JobRecord GetJobById(int jobId)
        {
            using (var db = new ATSContext())
            {
                return db.JobRecords
                    .Include(j => j.WindFarm)
                    .Include(j => j.Turbine)
                    .Include(j => j.Staff)
                    .FirstOrDefault(j => j.JobId == jobId);
            }
        }

        public List<JobRecord> GetJobsByStaffId(string staffId)
        {
            using (var db = new ATSContext())
            {
                return db.JobRecords
                    .Include(j => j.WindFarm)
                    .Include(j => j.Turbine)
                    .Where(j => j.StaffId == staffId)
                    .ToList();
            }
        }

        public List<JobRecord> GetActiveJobsByStaffId(string staffId)
        {
            using (var db = new ATSContext())
            {
                return db.JobRecords
                    .Include(j => j.WindFarm)
                    .Include(j => j.Turbine)
                    .Where(j => j.StaffId == staffId &&
                                j.JobComplete == "Awaiting Engineer")
                    .ToList();
            }
        }

        public List<JobRecord> GetCompletedJobsByStaffId(string staffId)
        {
            using (var db = new ATSContext())
            {
                return db.JobRecords
                    .Include(j => j.WindFarm)
                    .Include(j => j.Turbine)
                    .Where(j => j.StaffId == staffId &&
                                j.JobComplete == "Complete")
                    .ToList();
            }
        }

        public List<JobRecord> GetAllActiveJobs()
        {
            using (var db = new ATSContext())
            {
                return db.JobRecords
                    .Include(j => j.WindFarm)
                    .Include(j => j.Turbine)
                    .Include(j => j.Staff)
                    .Where(j => j.JobComplete == "Awaiting Engineer")
                    .ToList();
            }
        }

        public List<JobRecord> GetAllCompletedJobs()
        {
            using (var db = new ATSContext())
            {
                return db.JobRecords
                    .Include(j => j.WindFarm)
                    .Include(j => j.Turbine)
                    .Include(j => j.Staff)
                    .Where(j => j.JobComplete == "Complete")
                    .ToList();
            }
        }

        public bool AddJob(JobRecord job)
        {
            using (var db = new ATSContext())
            {
                db.JobRecords.Add(job);
                db.SaveChanges();
                return true;
            }
        }

        public bool UpdateJob(JobRecord updatedJob)
        {
            using (var db = new ATSContext())
            {
                var job = db.JobRecords.Find(updatedJob.JobId);

                if (job == null)
                {
                    return false;
                }

                job.JobDate = updatedJob.JobDate;
                job.JobTime = updatedJob.JobTime;
                job.FarmId = updatedJob.FarmId;
                job.TurbineId = updatedJob.TurbineId;
                job.StaffId = updatedJob.StaffId;
                job.JobType = updatedJob.JobType;
                job.FaultDescription = updatedJob.FaultDescription;

                job.MainGeneratorServiced = updatedJob.MainGeneratorServiced;
                job.GearboxServiced = updatedJob.GearboxServiced;
                job.YawMotorServiced = updatedJob.YawMotorServiced;
                job.InternalPassengerLiftServiced = updatedJob.InternalPassengerLiftServiced;

                job.MainGeneratorReplaced = updatedJob.MainGeneratorReplaced;
                job.GearboxReplaced = updatedJob.GearboxReplaced;
                job.YawMotorReplaced = updatedJob.YawMotorReplaced;
                job.InternalPassengerLiftReplaced = updatedJob.InternalPassengerLiftReplaced;

                job.JobComplete = updatedJob.JobComplete;

                db.SaveChanges();
                return true;
            }
        }

        public bool DeleteJob(int jobId)
        {
            using (var db = new ATSContext())
            {
                var job = db.JobRecords.Find(jobId);

                if (job == null)
                {
                    return false;
                }

                db.JobRecords.Remove(job);
                db.SaveChanges();
                return true;
            }
        }

        public bool MarkJobComplete(
            int jobId,
            bool mainGeneratorServiced,
            bool gearboxServiced,
            bool yawMotorServiced,
            bool internalPassengerLiftServiced,
            bool mainGeneratorReplaced,
            bool gearboxReplaced,
            bool yawMotorReplaced,
            bool internalPassengerLiftReplaced)
        {
            using (var db = new ATSContext())
            {
                var job = db.JobRecords
                    .Include(j => j.Turbine)
                    .FirstOrDefault(j => j.JobId == jobId);

                if (job == null)
                {
                    return false;
                }

                job.MainGeneratorServiced = mainGeneratorServiced;
                job.GearboxServiced = gearboxServiced;
                job.YawMotorServiced = yawMotorServiced;
                job.InternalPassengerLiftServiced = internalPassengerLiftServiced;

                job.MainGeneratorReplaced = mainGeneratorReplaced;
                job.GearboxReplaced = gearboxReplaced;
                job.YawMotorReplaced = yawMotorReplaced;
                job.InternalPassengerLiftReplaced = internalPassengerLiftReplaced;

                job.JobComplete = "Complete";

                job.Turbine.Status = "Active";

                if (job.JobType == "Scheduled Service")
                {
                    job.Turbine.RuntimeHours = 0;
                }

                db.SaveChanges();
                return true;
            }
        }
    }
}