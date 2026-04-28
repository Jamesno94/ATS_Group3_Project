using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

public class ATSContext : DbContext
{
    public ATSContext()
        : base("ATSConnection")
    {
    }

    public DbSet<WindFarm> WindFarms { get; set; }

    public DbSet<Turbine> Turbines { get; set; }

    public DbSet<Staff> Staff { get; set; }

    public DbSet<EngineerShift> Shifts { get; set; }

    public DbSet<JobRecord> Jobs { get; set; }

    public DbSet<User> Users { get; set; }
}