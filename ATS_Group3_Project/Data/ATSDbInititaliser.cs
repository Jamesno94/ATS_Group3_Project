using System.Data.Entity;
using System.Linq;
using ATS_Group3_Project;


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
        context.WindFarms.AddRange(new[]
        {
            new WindFarm
            {
                FarmName = "Whitelee Wind Farm",
                Address1 = "Moor Road",
                Address2 = "Eaglesham",
                City = "Glasgow",
                Postcode = "G76 0QQ",
                Region = "Glasgow"
            },

            new WindFarm
            {
                FarmName = "Beinn an Tuirc Wind Farm",
                Address1 = "Carradale",
                Address2 = "Campbeltown",
                City = "Campbeltown",
                Postcode = "PA28 6QY",
                Region = "Campbeltown"
            },

            new WindFarm
            {
                FarmName = "Clyde Wind Farm",
                Address1 = "B7076, Crawford to Beattock Road",
                Address2 = "Elvanfoot",
                City = "Biggar",
                Postcode = "ML12 6RL",
                Region = "Abington"
            }
        });

        context.SaveChanges();
    }

    private void SeedTurbines(ATSContext context)
    {
        WindFarm whitelee = context.WindFarms.First(f => f.FarmName == "Whitelee Wind Farm");
        WindFarm beinn = context.WindFarms.First(f => f.FarmName == "Beinn an Tuirc Wind Farm");
        WindFarm clyde = context.WindFarms.First(f => f.FarmName == "Clyde Wind Farm");

        context.Turbines.AddRange(new[]
        {
            new Turbine { TurbineId = "WL-01", Make = "Vestas", Model = "V150", FarmId = whitelee.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "WL-02", Make = "Vestas", Model = "V150", FarmId = whitelee.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "WL-03", Make = "Vestas", Model = "V150", FarmId = whitelee.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "WL-04", Make = "Vestas", Model = "V150", FarmId = whitelee.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "WL-05", Make = "Vestas", Model = "V150", FarmId = whitelee.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "WL-06", Make = "Vestas", Model = "V150", FarmId = whitelee.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "WL-07", Make = "Vestas", Model = "V150", FarmId = whitelee.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "WL-08", Make = "Vestas", Model = "V150", FarmId = whitelee.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "WL-09", Make = "Vestas", Model = "V150", FarmId = whitelee.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "WL-10", Make = "Vestas", Model = "V150", FarmId = whitelee.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "WL-11", Make = "Vestas", Model = "V150", FarmId = whitelee.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "WL-12", Make = "Vestas", Model = "V150", FarmId = whitelee.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "WL-13", Make = "Vestas", Model = "V150", FarmId = whitelee.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "WL-14", Make = "Vestas", Model = "V150", FarmId = whitelee.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "WL-15", Make = "Vestas", Model = "V150", FarmId = whitelee.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "WL-16", Make = "Vestas", Model = "V150", FarmId = whitelee.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "WL-17", Make = "Vestas", Model = "V150", FarmId = whitelee.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "WL-18", Make = "Vestas", Model = "V150", FarmId = whitelee.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "WL-19", Make = "Vestas", Model = "V150", FarmId = whitelee.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "WL-20", Make = "Vestas", Model = "V150", FarmId = whitelee.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "WL-21", Make = "Vestas", Model = "V150", FarmId = whitelee.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "WL-22", Make = "Vestas", Model = "V150", FarmId = whitelee.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "WL-23", Make = "Vestas", Model = "V150", FarmId = whitelee.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "WL-24", Make = "Vestas", Model = "V150", FarmId = whitelee.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "WL-25", Make = "Vestas", Model = "V150", FarmId = whitelee.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "WL-26", Make = "Vestas", Model = "V150", FarmId = whitelee.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "WL-27", Make = "Vestas", Model = "V150", FarmId = whitelee.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "WL-28", Make = "Vestas", Model = "V150", FarmId = whitelee.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "WL-29", Make = "Vestas", Model = "V150", FarmId = whitelee.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "WL-30", Make = "Vestas", Model = "V150", FarmId = whitelee.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "WL-31", Make = "Vestas", Model = "V150", FarmId = whitelee.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "WL-32", Make = "Vestas", Model = "V150", FarmId = whitelee.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "WL-33", Make = "Vestas", Model = "V150", FarmId = whitelee.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "WL-34", Make = "Vestas", Model = "V150", FarmId = whitelee.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "WL-35", Make = "Vestas", Model = "V150", FarmId = whitelee.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "WL-36", Make = "Vestas", Model = "V150", FarmId = whitelee.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "WL-37", Make = "Vestas", Model = "V150", FarmId = whitelee.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "WL-38", Make = "Vestas", Model = "V150", FarmId = whitelee.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "WL-39", Make = "Vestas", Model = "V150", FarmId = whitelee.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "WL-40", Make = "Vestas", Model = "V150", FarmId = whitelee.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "WL-41", Make = "Vestas", Model = "V150", FarmId = whitelee.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "WL-42", Make = "Vestas", Model = "V150", FarmId = whitelee.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "WL-43", Make = "Vestas", Model = "V150", FarmId = whitelee.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "WL-44", Make = "Vestas", Model = "V150", FarmId = whitelee.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "WL-45", Make = "Vestas", Model = "V150", FarmId = whitelee.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "WL-46", Make = "Vestas", Model = "V150", FarmId = whitelee.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "WL-47", Make = "Vestas", Model = "V150", FarmId = whitelee.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "WL-48", Make = "Vestas", Model = "V150", FarmId = whitelee.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "WL-49", Make = "Vestas", Model = "V150", FarmId = whitelee.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "WL-50", Make = "Vestas", Model = "V150", FarmId = whitelee.FarmId, RuntimeHours = 0, Status = "Active" },

            new Turbine { TurbineId = "BT-01", Make = "Siemens", Model = "SG4.5", FarmId = beinn.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "BT-02", Make = "Siemens", Model = "SG4.5", FarmId = beinn.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "BT-03", Make = "Siemens", Model = "SG4.5", FarmId = beinn.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "BT-04", Make = "Siemens", Model = "SG4.5", FarmId = beinn.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "BT-05", Make = "Siemens", Model = "SG4.5", FarmId = beinn.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "BT-06", Make = "Siemens", Model = "SG4.5", FarmId = beinn.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "BT-07", Make = "Siemens", Model = "SG4.5", FarmId = beinn.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "BT-08", Make = "Siemens", Model = "SG4.5", FarmId = beinn.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "BT-09", Make = "Siemens", Model = "SG4.5", FarmId = beinn.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "BT-10", Make = "Siemens", Model = "SG4.5", FarmId = beinn.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "BT-11", Make = "Siemens", Model = "SG4.5", FarmId = beinn.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "BT-12", Make = "Siemens", Model = "SG4.5", FarmId = beinn.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "BT-13", Make = "Siemens", Model = "SG4.5", FarmId = beinn.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "BT-14", Make = "Siemens", Model = "SG4.5", FarmId = beinn.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "BT-15", Make = "Siemens", Model = "SG4.5", FarmId = beinn.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "BT-16", Make = "Siemens", Model = "SG4.5", FarmId = beinn.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "BT-17", Make = "Siemens", Model = "SG4.5", FarmId = beinn.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "BT-18", Make = "Siemens", Model = "SG4.5", FarmId = beinn.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "BT-19", Make = "Siemens", Model = "SG4.5", FarmId = beinn.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "BT-20", Make = "Siemens", Model = "SG4.5", FarmId = beinn.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "BT-21", Make = "Siemens", Model = "SG4.5", FarmId = beinn.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "BT-22", Make = "Siemens", Model = "SG4.5", FarmId = beinn.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "BT-23", Make = "Siemens", Model = "SG4.5", FarmId = beinn.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "BT-24", Make = "Siemens", Model = "SG4.5", FarmId = beinn.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "BT-25", Make = "Siemens", Model = "SG4.5", FarmId = beinn.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "BT-26", Make = "Siemens", Model = "SG4.5", FarmId = beinn.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "BT-27", Make = "Siemens", Model = "SG4.5", FarmId = beinn.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "BT-28", Make = "Siemens", Model = "SG4.5", FarmId = beinn.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "BT-29", Make = "Siemens", Model = "SG4.5", FarmId = beinn.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "BT-30", Make = "Siemens", Model = "SG4.5", FarmId = beinn.FarmId, RuntimeHours = 0, Status = "Active" },

            new Turbine { TurbineId = "CL-01", Make = "GE", Model = "GE5.3", FarmId = clyde.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "CL-02", Make = "GE", Model = "GE5.3", FarmId = clyde.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "CL-03", Make = "GE", Model = "GE5.3", FarmId = clyde.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "CL-04", Make = "GE", Model = "GE5.3", FarmId = clyde.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "CL-05", Make = "GE", Model = "GE5.3", FarmId = clyde.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "CL-06", Make = "GE", Model = "GE5.3", FarmId = clyde.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "CL-07", Make = "GE", Model = "GE5.3", FarmId = clyde.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "CL-08", Make = "GE", Model = "GE5.3", FarmId = clyde.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "CL-09", Make = "GE", Model = "GE5.3", FarmId = clyde.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "CL-10", Make = "GE", Model = "GE5.3", FarmId = clyde.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "CL-11", Make = "GE", Model = "GE5.3", FarmId = clyde.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "CL-12", Make = "GE", Model = "GE5.3", FarmId = clyde.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "CL-13", Make = "GE", Model = "GE5.3", FarmId = clyde.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "CL-14", Make = "GE", Model = "GE5.3", FarmId = clyde.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "CL-15", Make = "GE", Model = "GE5.3", FarmId = clyde.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "CL-16", Make = "GE", Model = "GE5.3", FarmId = clyde.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "CL-17", Make = "GE", Model = "GE5.3", FarmId = clyde.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "CL-18", Make = "GE", Model = "GE5.3", FarmId = clyde.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "CL-19", Make = "GE", Model = "GE5.3", FarmId = clyde.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "CL-20", Make = "GE", Model = "GE5.3", FarmId = clyde.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "CL-21", Make = "GE", Model = "GE5.3", FarmId = clyde.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "CL-22", Make = "GE", Model = "GE5.3", FarmId = clyde.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "CL-23", Make = "GE", Model = "GE5.3", FarmId = clyde.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "CL-24", Make = "GE", Model = "GE5.3", FarmId = clyde.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "CL-25", Make = "GE", Model = "GE5.3", FarmId = clyde.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "CL-26", Make = "GE", Model = "GE5.3", FarmId = clyde.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "CL-27", Make = "GE", Model = "GE5.3", FarmId = clyde.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "CL-28", Make = "GE", Model = "GE5.3", FarmId = clyde.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "CL-29", Make = "GE", Model = "GE5.3", FarmId = clyde.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "CL-30", Make = "GE", Model = "GE5.3", FarmId = clyde.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "CL-31", Make = "GE", Model = "GE5.3", FarmId = clyde.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "CL-32", Make = "GE", Model = "GE5.3", FarmId = clyde.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "CL-33", Make = "GE", Model = "GE5.3", FarmId = clyde.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "CL-34", Make = "GE", Model = "GE5.3", FarmId = clyde.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "CL-35", Make = "GE", Model = "GE5.3", FarmId = clyde.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "CL-36", Make = "GE", Model = "GE5.3", FarmId = clyde.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "CL-37", Make = "GE", Model = "GE5.3", FarmId = clyde.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "CL-38", Make = "GE", Model = "GE5.3", FarmId = clyde.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "CL-39", Make = "GE", Model = "GE5.3", FarmId = clyde.FarmId, RuntimeHours = 0, Status = "Active" },
            new Turbine { TurbineId = "CL-40", Make = "GE", Model = "GE5.3", FarmId = clyde.FarmId, RuntimeHours = 0, Status = "Active" }
        });

        context.SaveChanges();
    }

    private void SeedStaff(ATSContext context)
    {
        context.Staff.AddRange(new[]
        {
        new Staff { StaffId = "ENG-001", FirstName = "James", LastName = "Black", WorkMobile = "0712345601", HomeMobile = "01415551001", Email = "eng001@ats.com", Address1 = "12 Buchanan Street", Address2 = null, City = "Glasgow", Postcode = "G1 3LB", Salary = 45000, Role = "Engineer" },
        new Staff { StaffId = "ENG-002", FirstName = "Callum", LastName = "McDonald", WorkMobile = "0712345602", HomeMobile = "01415551002", Email = "eng002@ats.com", Address1 = "45 Sauchiehall Street", Address2 = "Flat 2/1", City = "Glasgow", Postcode = "G2 3AT", Salary = 45000, Role = "Engineer" },
        new Staff { StaffId = "ENG-003", FirstName = "Sarah", LastName = "Miller", WorkMobile = "0712345603", HomeMobile = "07711223303", Email = "eng003@ats.com", Address1 = "8 Argyle Street", Address2 = null, City = "Glasgow", Postcode = "G2 8AD", Salary = 45000, Role = "Engineer" },
        new Staff { StaffId = "ENG-004", FirstName = "Alistair", LastName = "Graham", WorkMobile = "0712345604", HomeMobile = "01415551004", Email = "eng004@ats.com", Address1 = "102 Byres Road", Address2 = null, City = "Glasgow", Postcode = "G12 8TB", Salary = 45000, Role = "Engineer" },
        new Staff { StaffId = "ENG-005", FirstName = "Fiona", LastName = "Campbell", WorkMobile = "0712345605", HomeMobile = "07711223305", Email = "eng005@ats.com", Address1 = "19 Duke Street", Address2 = "Top Floor", City = "Glasgow", Postcode = "G4 0UL", Salary = 45000, Role = "Engineer" },
        new Staff { StaffId = "ENG-006", FirstName = "David", LastName = "Ross", WorkMobile = "0712345606", HomeMobile = "01415551006", Email = "eng006@ats.com", Address1 = "33 Pollokshaws Road", Address2 = null, City = "Glasgow", Postcode = "G41 1QS", Salary = 45000, Role = "Engineer" },
        new Staff { StaffId = "ENG-007", FirstName = "Siobhan", LastName = "Murray", WorkMobile = "0712345607", HomeMobile = "07711223307", Email = "eng007@ats.com", Address1 = "77 Great Western Road", Address2 = null, City = "Glasgow", Postcode = "G4 9AH", Salary = 45000, Role = "Engineer" },
        new Staff { StaffId = "ENG-008", FirstName = "Lewis", LastName = "Hamilton", WorkMobile = "0712345608", HomeMobile = "01415551008", Email = "eng008@ats.com", Address1 = "5 High Street", Address2 = "Flat 12", City = "Glasgow", Postcode = "G1 1QR", Salary = 45000, Role = "Engineer" },
        new Staff { StaffId = "ENG-009", FirstName = "Ewan", LastName = "McGregor", WorkMobile = "0712345609", HomeMobile = "07711223309", Email = "eng009@ats.com", Address1 = "21 Victoria Road", Address2 = null, City = "Glasgow", Postcode = "G42 7AB", Salary = 45000, Role = "Engineer" },
        new Staff { StaffId = "ENG-010", FirstName = "Isla", LastName = "Stewart", WorkMobile = "0712345610", HomeMobile = "01415551010", Email = "eng010@ats.com", Address1 = "90 Paisley Road West", Address2 = null, City = "Glasgow", Postcode = "G51 1BU", Salary = 45000, Role = "Engineer" },
        new Staff { StaffId = "ENG-011", FirstName = "Robert", LastName = "Burns", WorkMobile = "0712345611", HomeMobile = "07711223311", Email = "eng011@ats.com", Address1 = "14 Cathcart Road", Address2 = null, City = "Glasgow", Postcode = "G42 7BE", Salary = 45000, Role = "Engineer" },
        new Staff { StaffId = "ENG-012", FirstName = "Mhairi", LastName = "Robertson", WorkMobile = "0712345612", HomeMobile = "01415551012", Email = "eng012@ats.com", Address1 = "3 Castle Street", Address2 = null, City = "Glasgow", Postcode = "G4 0RB", Salary = 45000, Role = "Engineer" },
        new Staff { StaffId = "ENG-013", FirstName = "Craig", LastName = "Fraser", WorkMobile = "0712345613", HomeMobile = "07711223313", Email = "eng013@ats.com", Address1 = "56 Maryhill Road", Address2 = "Flat 0/2", City = "Glasgow", Postcode = "G20 7PZ", Salary = 45000, Role = "Engineer" },
        new Staff { StaffId = "ENG-014", FirstName = "Catriona", LastName = "McLeod", WorkMobile = "0712345614", HomeMobile = "01415551014", Email = "eng014@ats.com", Address1 = "11 Gallowgate", Address2 = null, City = "Glasgow", Postcode = "G1 5AA", Salary = 45000, Role = "Engineer" },
        new Staff { StaffId = "ENG-015", FirstName = "Angus", LastName = "Sutherland", WorkMobile = "0712345615", HomeMobile = "07711223315", Email = "eng015@ats.com", Address1 = "22 Dumbarton Road", Address2 = null, City = "Glasgow", Postcode = "G11 6PA", Salary = 45000, Role = "Engineer" },
        new Staff { StaffId = "ENG-016", FirstName = "Bethany", LastName = "Wallace", WorkMobile = "0712345616", HomeMobile = "01415551016", Email = "eng016@ats.com", Address1 = "88 Hyndland Road", Address2 = "Garden Flat", City = "Glasgow", Postcode = "G12 9PZ", Salary = 45000, Role = "Engineer" },
        new Staff { StaffId = "ENG-017", FirstName = "Hamish", LastName = "Anderson", WorkMobile = "0712345617", HomeMobile = "07711223317", Email = "eng017@ats.com", Address1 = "40 Alexandra Parade", Address2 = null, City = "Glasgow", Postcode = "G31 3AU", Salary = 45000, Role = "Engineer" },
        new Staff { StaffId = "ENG-018", FirstName = "Lorraine", LastName = "Kelly", WorkMobile = "0712345618", HomeMobile = "01415551018", Email = "eng018@ats.com", Address1 = "15 Clyde Place", Address2 = null, City = "Glasgow", Postcode = "G5 8AQ", Salary = 45000, Role = "Engineer" },
        new Staff { StaffId = "ENG-019", FirstName = "Grant", LastName = "Morrison", WorkMobile = "0712345619", HomeMobile = "07711223319", Email = "eng019@ats.com", Address1 = "62 Bath Street", Address2 = null, City = "Glasgow", Postcode = "G2 2HG", Salary = 45000, Role = "Engineer" },
        new Staff { StaffId = "ENG-020", FirstName = "Freya", LastName = "Cunningham", WorkMobile = "0712345620", HomeMobile = "01415551020", Email = "eng020@ats.com", Address1 = "20 Miller Street", Address2 = "Suite 4", City = "Glasgow", Postcode = "G1 1DT", Salary = 45000, Role = "Engineer" },

        new Staff { StaffId = "CALL-001", FirstName = "Callum", LastName = "Hoodlum", WorkMobile = "0712345701", HomeMobile = "01415559999", Email = "call001@ats.com", Address1 = "1 Control Centre", Address2 = "George Square", City = "Glasgow", Postcode = "G2 1DU", Salary = 32000, Role = "CallHandler" }
        });

        context.SaveChanges();
    }

    private void SeedEngineerShifts(ATSContext context)
    {
        context.EngineerShifts.AddRange(new[]
        {
            new EngineerShift { StaffId = "ENG-001", ShiftType = "Early", Monday = true, Tuesday = true, Wednesday = true, Thursday = true, Friday = true, Saturday = false, Sunday = false },
            new EngineerShift { StaffId = "ENG-002", ShiftType = "Early", Monday = true, Tuesday = true, Wednesday = true, Thursday = true, Friday = true, Saturday = false, Sunday = false },
            new EngineerShift { StaffId = "ENG-003", ShiftType = "Early", Monday = true, Tuesday = true, Wednesday = true, Thursday = true, Friday = true, Saturday = false, Sunday = false },
            new EngineerShift { StaffId = "ENG-004", ShiftType = "Early", Monday = true, Tuesday = true, Wednesday = true, Thursday = true, Friday = true, Saturday = false, Sunday = false },
            new EngineerShift { StaffId = "ENG-005", ShiftType = "Early", Monday = true, Tuesday = true, Wednesday = true, Thursday = true, Friday = true, Saturday = false, Sunday = false },
            new EngineerShift { StaffId = "ENG-006", ShiftType = "Early", Monday = true, Tuesday = true, Wednesday = true, Thursday = true, Friday = true, Saturday = false, Sunday = false },
            new EngineerShift { StaffId = "ENG-007", ShiftType = "Early", Monday = true, Tuesday = true, Wednesday = true, Thursday = true, Friday = true, Saturday = false, Sunday = false },
            new EngineerShift { StaffId = "ENG-008", ShiftType = "Early", Monday = true, Tuesday = true, Wednesday = true, Thursday = true, Friday = true, Saturday = false, Sunday = false },
            new EngineerShift { StaffId = "ENG-009", ShiftType = "Early", Monday = true, Tuesday = true, Wednesday = true, Thursday = true, Friday = true, Saturday = false, Sunday = false },
            new EngineerShift { StaffId = "ENG-010", ShiftType = "Early", Monday = true, Tuesday = true, Wednesday = true, Thursday = true, Friday = true, Saturday = false, Sunday = false },
            new EngineerShift { StaffId = "ENG-011", ShiftType = "Early", Monday = true, Tuesday = true, Wednesday = true, Thursday = true, Friday = true, Saturday = false, Sunday = false },
            new EngineerShift { StaffId = "ENG-012", ShiftType = "Early", Monday = true, Tuesday = true, Wednesday = true, Thursday = true, Friday = true, Saturday = false, Sunday = false },
            new EngineerShift { StaffId = "ENG-013", ShiftType = "Early", Monday = true, Tuesday = true, Wednesday = true, Thursday = true, Friday = true, Saturday = false, Sunday = false },
            new EngineerShift { StaffId = "ENG-014", ShiftType = "Early", Monday = true, Tuesday = true, Wednesday = true, Thursday = true, Friday = true, Saturday = false, Sunday = false },

            new EngineerShift { StaffId = "ENG-015", ShiftType = "Late", Monday = true, Tuesday = true, Wednesday = true, Thursday = true, Friday = true, Saturday = false, Sunday = false },
            new EngineerShift { StaffId = "ENG-016", ShiftType = "Late", Monday = true, Tuesday = true, Wednesday = true, Thursday = true, Friday = true, Saturday = false, Sunday = false },
            new EngineerShift { StaffId = "ENG-017", ShiftType = "Late", Monday = true, Tuesday = true, Wednesday = true, Thursday = true, Friday = true, Saturday = false, Sunday = false },
            new EngineerShift { StaffId = "ENG-018", ShiftType = "Late", Monday = true, Tuesday = true, Wednesday = true, Thursday = true, Friday = true, Saturday = false, Sunday = false },
            new EngineerShift { StaffId = "ENG-019", ShiftType = "Late", Monday = true, Tuesday = true, Wednesday = true, Thursday = true, Friday = true, Saturday = false, Sunday = false },
            new EngineerShift { StaffId = "ENG-020", ShiftType = "Late", Monday = true, Tuesday = true, Wednesday = true, Thursday = true, Friday = true, Saturday = false, Sunday = false }
        });

        context.SaveChanges();
    }

    private void SeedUsers(ATSContext context)
    {
        context.Users.AddRange(new[]
        {
            CreateUser("ENG-001"),
            CreateUser("ENG-002"),
            CreateUser("ENG-003"),
            CreateUser("ENG-004"),
            CreateUser("ENG-005"),
            CreateUser("ENG-006"),
            CreateUser("ENG-007"),
            CreateUser("ENG-008"),
            CreateUser("ENG-009"),
            CreateUser("ENG-010"),
            CreateUser("ENG-011"),
            CreateUser("ENG-012"),
            CreateUser("ENG-013"),
            CreateUser("ENG-014"),
            CreateUser("ENG-015"),
            CreateUser("ENG-016"),
            CreateUser("ENG-017"),
            CreateUser("ENG-018"),
            CreateUser("ENG-019"),
            CreateUser("ENG-020"),
            CreateUser("CALL-001")
        });

        context.SaveChanges();
    }

    private User CreateUser(string staffId)
    {
        var password = PasswordHelper.HashPassword("Password1");

        return new User
        {
            StaffId = staffId,
            PasswordHash = password.hash,
            PasswordSalt = password.salt
        };
    }
}