using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ATS_Group3_Project
{
    public class TurbineManager
    {
        public List<Turbine> GetAllTurbines()
        {
            using (var db = new ATSContext())
            {
                return db.Turbines
                    .Include(t => t.WindFarm)
                    .ToList();
            }
        }

        public Turbine GetTurbineById(string turbineId)
        {
            using (var db = new ATSContext())
            {
                return db.Turbines
                    .Include(t => t.WindFarm)
                    .FirstOrDefault(t => t.TurbineId == turbineId);
            }
        }

        public List<Turbine> GetTurbinesByFarmId(int farmId)
        {
            using (var db = new ATSContext())
            {
                return db.Turbines
                    .Where(t => t.FarmId == farmId)
                    .ToList();
            }
        }

        public bool AddTurbine(Turbine turbine)
        {
            using (var db = new ATSContext())
            {
                db.Turbines.Add(turbine);
                db.SaveChanges();
                return true;
            }
        }

        public bool UpdateTurbine(Turbine updatedTurbine)
        {
            using (var db = new ATSContext())
            {
                var turbine = db.Turbines.Find(updatedTurbine.TurbineId);

                if (turbine == null)
                {
                    return false;
                }

                turbine.Make = updatedTurbine.Make;
                turbine.Model = updatedTurbine.Model;
                turbine.FarmId = updatedTurbine.FarmId;
                turbine.RuntimeHours = updatedTurbine.RuntimeHours;
                turbine.Status = updatedTurbine.Status;

                db.SaveChanges();
                return true;
            }
        }

        public bool DeleteTurbine(string turbineId)
        {
            using (var db = new ATSContext())
            {
                var turbine = db.Turbines.Find(turbineId);

                if (turbine == null)
                {
                    return false;
                }

                db.Turbines.Remove(turbine);
                db.SaveChanges();
                return true;
            }
        }

        public bool UpdateRuntimeHours(string turbineId, int newRuntimeHours)
        {
            using (var db = new ATSContext())
            {
                var turbine = db.Turbines.Find(turbineId);

                if (turbine == null)
                {
                    return false;
                }

                turbine.RuntimeHours = newRuntimeHours;

                if (turbine.RuntimeHours >= 2000 && turbine.Status == "Active")
                {
                    turbine.Status = "Requires Service";
                    db.SaveChanges();

                    DispatchManager dispatch = new DispatchManager();
                    dispatch.CreateScheduledServiceJob(turbineId);

                    return true;
                }

                db.SaveChanges();
                return true;
            }
        }
    }
}