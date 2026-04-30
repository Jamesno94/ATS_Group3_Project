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
            new Staff { StaffId = "ENG-001", FirstName = "Engineer", LastName = "001", WorkMobile = "0712345601", HomeMobile = null, Email = "eng001@ats.com", Address1 = "1 Turbine Road", Address2 = null, City = "Glasgow", Postcode = "G1 1AA", Salary = 45000, Role = "Engineer" },
            new Staff { StaffId = "ENG-002", FirstName = "Engineer", LastName = "002", WorkMobile = "0712345602", HomeMobile = null, Email = "eng002@ats.com", Address1 = "2 Turbine Road", Address2 = null, City = "Glasgow", Postcode = "G1 1AA", Salary = 45000, Role = "Engineer" },
            new Staff { StaffId = "ENG-003", FirstName = "Engineer", LastName = "003", WorkMobile = "0712345603", HomeMobile = null, Email = "eng003@ats.com", Address1 = "3 Turbine Road", Address2 = null, City = "Glasgow", Postcode = "G1 1AA", Salary = 45000, Role = "Engineer" },
            new Staff { StaffId = "ENG-004", FirstName = "Engineer", LastName = "004", WorkMobile = "0712345604", HomeMobile = null, Email = "eng004@ats.com", Address1 = "4 Turbine Road", Address2 = null, City = "Glasgow", Postcode = "G1 1AA", Salary = 45000, Role = "Engineer" },
            new Staff { StaffId = "ENG-005", FirstName = "Engineer", LastName = "005", WorkMobile = "0712345605", HomeMobile = null, Email = "eng005@ats.com", Address1 = "5 Turbine Road", Address2 = null, City = "Glasgow", Postcode = "G1 1AA", Salary = 45000, Role = "Engineer" },
            new Staff { StaffId = "ENG-006", FirstName = "Engineer", LastName = "006", WorkMobile = "0712345606", HomeMobile = null, Email = "eng006@ats.com", Address1 = "6 Turbine Road", Address2 = null, City = "Glasgow", Postcode = "G1 1AA", Salary = 45000, Role = "Engineer" },
            new Staff { StaffId = "ENG-007", FirstName = "Engineer", LastName = "007", WorkMobile = "0712345607", HomeMobile = null, Email = "eng007@ats.com", Address1 = "7 Turbine Road", Address2 = null, City = "Glasgow", Postcode = "G1 1AA", Salary = 45000, Role = "Engineer" },
            new Staff { StaffId = "ENG-008", FirstName = "Engineer", LastName = "008", WorkMobile = "0712345608", HomeMobile = null, Email = "eng008@ats.com", Address1 = "8 Turbine Road", Address2 = null, City = "Glasgow", Postcode = "G1 1AA", Salary = 45000, Role = "Engineer" },
            new Staff { StaffId = "ENG-009", FirstName = "Engineer", LastName = "009", WorkMobile = "0712345609", HomeMobile = null, Email = "eng009@ats.com", Address1 = "9 Turbine Road", Address2 = null, City = "Glasgow", Postcode = "G1 1AA", Salary = 45000, Role = "Engineer" },
            new Staff { StaffId = "ENG-010", FirstName = "Engineer", LastName = "010", WorkMobile = "0712345610", HomeMobile = null, Email = "eng010@ats.com", Address1 = "10 Turbine Road", Address2 = null, City = "Glasgow", Postcode = "G1 1AA", Salary = 45000, Role = "Engineer" },
            new Staff { StaffId = "ENG-011", FirstName = "Engineer", LastName = "011", WorkMobile = "0712345611", HomeMobile = null, Email = "eng011@ats.com", Address1 = "11 Turbine Road", Address2 = null, City = "Glasgow", Postcode = "G1 1AA", Salary = 45000, Role = "Engineer" },
            new Staff { StaffId = "ENG-012", FirstName = "Engineer", LastName = "012", WorkMobile = "0712345612", HomeMobile = null, Email = "eng012@ats.com", Address1 = "12 Turbine Road", Address2 = null, City = "Glasgow", Postcode = "G1 1AA", Salary = 45000, Role = "Engineer" },
            new Staff { StaffId = "ENG-013", FirstName = "Engineer", LastName = "013", WorkMobile = "0712345613", HomeMobile = null, Email = "eng013@ats.com", Address1 = "13 Turbine Road", Address2 = null, City = "Glasgow", Postcode = "G1 1AA", Salary = 45000, Role = "Engineer" },
            new Staff { StaffId = "ENG-014", FirstName = "Engineer", LastName = "014", WorkMobile = "0712345614", HomeMobile = null, Email = "eng014@ats.com", Address1 = "14 Turbine Road", Address2 = null, City = "Glasgow", Postcode = "G1 1AA", Salary = 45000, Role = "Engineer" },
            new Staff { StaffId = "ENG-015", FirstName = "Engineer", LastName = "015", WorkMobile = "0712345615", HomeMobile = null, Email = "eng015@ats.com", Address1 = "15 Turbine Road", Address2 = null, City = "Glasgow", Postcode = "G1 1AA", Salary = 45000, Role = "Engineer" },
            new Staff { StaffId = "ENG-016", FirstName = "Engineer", LastName = "016", WorkMobile = "0712345616", HomeMobile = null, Email = "eng016@ats.com", Address1 = "16 Turbine Road", Address2 = null, City = "Glasgow", Postcode = "G1 1AA", Salary = 45000, Role = "Engineer" },
            new Staff { StaffId = "ENG-017", FirstName = "Engineer", LastName = "017", WorkMobile = "0712345617", HomeMobile = null, Email = "eng017@ats.com", Address1 = "17 Turbine Road", Address2 = null, City = "Glasgow", Postcode = "G1 1AA", Salary = 45000, Role = "Engineer" },
            new Staff { StaffId = "ENG-018", FirstName = "Engineer", LastName = "018", WorkMobile = "0712345618", HomeMobile = null, Email = "eng018@ats.com", Address1 = "18 Turbine Road", Address2 = null, City = "Glasgow", Postcode = "G1 1AA", Salary = 45000, Role = "Engineer" },
            new Staff { StaffId = "ENG-019", FirstName = "Engineer", LastName = "019", WorkMobile = "0712345619", HomeMobile = null, Email = "eng019@ats.com", Address1 = "19 Turbine Road", Address2 = null, City = "Glasgow", Postcode = "G1 1AA", Salary = 45000, Role = "Engineer" },
            new Staff { StaffId = "ENG-020", FirstName = "Engineer", LastName = "020", WorkMobile = "0712345620", HomeMobile = null, Email = "eng020@ats.com", Address1 = "20 Turbine Road", Address2 = null, City = "Glasgow", Postcode = "G1 1AA", Salary = 45000, Role = "Engineer" },

            new Staff { StaffId = "CALL-001", FirstName = "Call", LastName = "Handler", WorkMobile = "07000000001", HomeMobile = null, Email = "call001@ats.com", Address1 = "1 Control Centre", Address2 = null, City = "Glasgow", Postcode = "G1 2BB", Salary = 32000, Role = "Call Handler" }
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