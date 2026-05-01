using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATS_Group3_Project
{
    public class JobRecord
    {
        [Key]
        public int JobId { get; set; }

        [Required]
        public DateTime JobDate { get; set; }

        [Required]
        public string JobTime { get; set; }
        // Early or Late

        [Required]
        public int FarmId { get; set; }

        [Required]
        public string TurbineId { get; set; }

        [Required]
        public string StaffId { get; set; }

        [Required]
        public string JobType { get; set; }
        // Scheduled Service or Fault

        public string FaultDescription { get; set; }
        // Optional, mainly used for fault jobs

        [Required]
        public bool MainGeneratorServiced { get; set; }

        [Required]
        public bool GearboxServiced { get; set; }

        [Required]
        public bool YawMotorServiced { get; set; }

        [Required]
        public bool InternalPassengerLiftServiced { get; set; }

        [Required]
        public bool MainGeneratorReplaced { get; set; }

        [Required]
        public bool GearboxReplaced { get; set; }

        [Required]
        public bool YawMotorReplaced { get; set; }

        [Required]
        public bool InternalPassengerLiftReplaced { get; set; }

        [Required]
        public string JobComplete { get; set; }
        // Awaiting Engineer or Complete

        [ForeignKey("FarmId")]
        public virtual WindFarm WindFarm { get; set; }

        [ForeignKey("TurbineId")]
        public virtual Turbine Turbine { get; set; }

        [ForeignKey("StaffId")]
        public virtual Staff Staff { get; set; }

        public JobRecord()
        {
            JobDate = DateTime.Today;
            JobTime = "Early";
            JobType = "Scheduled Service";
            JobComplete = "Awaiting Engineer";

            MainGeneratorServiced = false;
            GearboxServiced = false;
            YawMotorServiced = false;
            InternalPassengerLiftServiced = false;

            MainGeneratorReplaced = false;
            GearboxReplaced = false;
            YawMotorReplaced = false;
            InternalPassengerLiftReplaced = false;
        }
    }
}