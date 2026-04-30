using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ATSContext : DbContext
{
    public ATSContext() : base("ATSConnection")
    {
    }

    public DbSet<WindFarm> WindFarms { get; set; }
    public DbSet<Turbine> Turbines { get; set; }
    public DbSet<Staff> Staff { get; set; }
    public DbSet<EngineerShift> EngineerShifts { get; set; }
    public DbSet<JobRecord> Jobs { get; set; }
    public DbSet<User> Users { get; set; }
}
public class ATSDbInitializer : DropCreateDatabaseIfModelChanges<ATSContext>
{
    protected override void Seed(ATSContext context)
    {
        SeedWindFarms(context);
        SeedTurbines(context);
        SeedStaff(context);
        SeedEngineerShifts(context);
        SeedUsers(context);

        base.Seed(context);
    }

    private void SeedWindFarms(ATSContext context)
    {
        context.WindFarms.Add(new WindFarm
        {
            FarmName = "Whitelee Wind Farm",
            Address1 = "Moor Road",
            Address2 = "Eaglesham",
            City = "Glasgow",
            Postcode = "G76 0QQ",
            Region = "Glasgow"
        });

        context.WindFarms.Add(new WindFarm
        {
            FarmName = "Beinn an Tuirc Wind Farm",
            Address1 = "Carradale",
            Address2 = "Campbeltown",
            City = "Campbeltown",
            Postcode = "PA28 6QY",
            Region = "Campbeltown"
        });

        context.WindFarms.Add(new WindFarm
        {
            FarmName = "Clyde Wind Farm",
            Address1 = "B7076, Crawford to Beattock Road",
            Address2 = "Elvanfoot",
            City = "Biggar",
            Postcode = "ML12 6RL",
            Region = "Abington"
        });

        context.SaveChanges();
    }

    private void SeedTurbines(ATSContext context)
    {
        var whitelee = context.WindFarms.Find(1);
        var beinn = context.WindFarms.Find(2);
        var clyde = context.WindFarms.Find(3);

        for (int i = 1; i <= 50; i++)
        {
            context.Turbines.Add(new Turbine
            {
                TurbineId = "WL-" + i.ToString("00"),
                Make = "Vestas",
                Model = "V150",
                FarmId = whitelee.FarmId,
                RuntimeHours = 0,
                Status = "Active"
            });
        }

        for (int i = 1; i <= 30; i++)
        {
            context.Turbines.Add(new Turbine
            {
                TurbineId = "BT-" + i.ToString("00"),
                Make = "Siemens",
                Model = "SG4.5",
                FarmId = beinn.FarmId,
                RuntimeHours = 0,
                Status = "Active"
            });
        }

        for (int i = 1; i <= 40; i++)
        {
            context.Turbines.Add(new Turbine
            {
                TurbineId = "CL-" + i.ToString("00"),
                Make = "GE",
                Model = "GE5.3",
                FarmId = clyde.FarmId,
                RuntimeHours = 0,
                Status = "Active"
            });
        }

        context.SaveChanges();
    }

    private void SeedStaff(ATSContext context)
    {
        for (int i = 1; i <= 20; i++)
        {
            context.Staff.Add(new Staff
            {
                StaffId = "ENG-" + i.ToString("000"),
                FirstName = "Engineer",
                LastName = i.ToString("000"),
                WorkMobile = "07123456" + i.ToString("00"),
                HomeMobile = null,
                Email = "eng" + i.ToString("000") + "@ats.com",
                Address1 = i + " Turbine Road",
                Address2 = null,
                City = "Glasgow",
                Postcode = "G1 1AA",
                Salary = 45000,
                Role = "Engineer"
            });
        }

        context.Staff.Add(new Staff
        {
            StaffId = "CALL-001",
            FirstName = "Call",
            LastName = "Handler",
            WorkMobile = "07000000001",
            HomeMobile = null,
            Email = "call001@ats.com",
            Address1 = "1 Control Centre",
            Address2 = null,
            City = "Glasgow",
            Postcode = "G1 2BB",
            Salary = 32000,
            Role = "Call Handler"
        });

        context.SaveChanges();
    }

    private void SeedEngineerShifts(ATSContext context)
    {
        for (int i = 1; i <= 20; i++)
        {
            string staffId = "ENG-" + i.ToString("000");

            context.EngineerShifts.Add(new EngineerShift
            {
                StaffId = staffId,
                ShiftType = i <= 14 ? "Early" : "Late",
                Monday = true,
                Tuesday = true,
                Wednesday = true,
                Thursday = true,
                Friday = true,
                Saturday = false,
                Sunday = false
            });
        }

        context.SaveChanges();
    }

    private void SeedUsers(ATSContext context)
    {
        for (int i = 1; i <= 20; i++)
        {
            string staffId = "ENG-" + i.ToString("000");
            var password = PasswordHelper.HashPassword("Password1");

            context.Users.Add(new User
            {
                StaffId = staffId,
                PasswordHash = password.hash,
                PasswordSalt = password.salt
            });
        }

        var handlerPassword = PasswordHelper.HashPassword("Password1");

        context.Users.Add(new User
        {
            StaffId = "CALL-001",
            PasswordHash = handlerPassword.hash,
            PasswordSalt = handlerPassword.salt
        });

        context.SaveChanges();
    }
}