using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ATS_Group3_Project
{
    public class WindFarmManager
    {
        public List<WindFarm> GetAllWindFarms()
        {
            using (var db = new ATSContext())
            {
                return db.WindFarms
                    .Include(w => w.Turbines)
                    .ToList();
            }
        }

        public WindFarm GetWindFarmById(int farmId)
        {
            using (var db = new ATSContext())
            {
                return db.WindFarms
                    .Include(w => w.Turbines)
                    .FirstOrDefault(w => w.FarmId == farmId);
            }
        }

        public bool AddWindFarm(WindFarm farm)
        {
            using (var db = new ATSContext())
            {
                db.WindFarms.Add(farm);
                db.SaveChanges();
                return true;
            }
        }

        public bool UpdateWindFarm(WindFarm updatedFarm)
        {
            using (var db = new ATSContext())
            {
                var farm = db.WindFarms.Find(updatedFarm.FarmId);

                if (farm == null)
                {
                    return false;
                }

                farm.FarmName = updatedFarm.FarmName;
                farm.Address1 = updatedFarm.Address1;
                farm.Address2 = updatedFarm.Address2;
                farm.City = updatedFarm.City;
                farm.Postcode = updatedFarm.Postcode;
                farm.Region = updatedFarm.Region;

                db.SaveChanges();
                return true;
            }
        }

        public bool DeleteWindFarm(int farmId)
        {
            using (var db = new ATSContext())
            {
                var farm = db.WindFarms.Find(farmId);

                if (farm == null)
                {
                    return false;
                }

                db.WindFarms.Remove(farm);
                db.SaveChanges();
                return true;
            }
        }
    }
}