using System.Data.Entity;
using ATS_Group3_Project;
using System.Data.Entity.ModelConfiguration.Conventions;

public class ATSContext : DbContext
{
    public ATSContext() : base("ATSConnection")
    {
    }

    public DbSet<WindFarm> WindFarms { get; set; }
    public DbSet<Turbine> Turbines { get; set; }
    public DbSet<Staff> Staff { get; set; }
    public DbSet<EngineerShift> EngineerShifts { get; set; }
    public DbSet<JobRecord> JobRecords { get; set; }
    public DbSet<User> Users { get; set; }
}