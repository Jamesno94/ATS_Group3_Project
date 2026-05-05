using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ATS_Group3_Project
{
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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Entity<Turbine>()
                .HasRequired(t => t.WindFarm)
                .WithMany(w => w.Turbines)
                .HasForeignKey(t => t.FarmId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<JobRecord>()
                .HasRequired(j => j.WindFarm)
                .WithMany()
                .HasForeignKey(j => j.FarmId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<JobRecord>()
                .HasRequired(j => j.Turbine)
                .WithMany()
                .HasForeignKey(j => j.TurbineId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<JobRecord>()
                .HasRequired(j => j.Staff)
                .WithMany()
                .HasForeignKey(j => j.StaffId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasRequired(u => u.Staff)
                .WithMany()
                .HasForeignKey(u => u.StaffId)
                .WillCascadeOnDelete(false);

            base.OnModelCreating(modelBuilder);
        }
    }
}