using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ATS_Group3_Project.ATS_Group3_Project;

namespace ATS_Group3_Project
{
    public class ATLDbContext : DbContext
    {
        public DbSet<JobRecord> JobRecords { get; set; }

        public DbSet<Staff> Staffs { get; set; }

        public DbSet<Turbine> Turbines { get; set; }
        
        public DbSet<Windfarm> Windfarms { get; set; }

        public DbSet<EngineerShift> EngineerShifts { get; set; }


        public ATLDbContext() : base("ATLDbContext")
        {
            Database.SetInitializer(new ATLDbInitialiser());
        }
    }

    public class ATLDbInitialiser : DropCreateDatabaseAlways<ATLDbContext>
    {
        protected override void Seed(ATLDbContext context)
        {
            base.Seed(context);

            Staff staff1 = new Staff
            {
                StaffID = "ENG-001",
                FirstName = "John",
                LastName = "Smith",
                WorkPhoneNo = "0123456789",
                HomePhoneNo = "0987654321",
                WorkEmail = "john.smith@example.com",
                Role = "Engineer"
            };
            context.Staffs.Add(staff1);
            context.SaveChanges();
        }
    }
}
