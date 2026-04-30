using System;
using System.ComponentModel.DataAnnotations;
using ATS_Group3_Project;
using System.Data.Entity;


public class JobRecord
{
    [Key]
    public int JobId { get; set; }

    public DateTime JobDate { get; set; }

    public string JobTime { get; set; }

    public string JobType { get; set; }

    public string FaultDescription { get; set; }

    public bool GeneratorServiced { get; set; }
    public bool GearboxServiced { get; set; }

    public bool GeneratorReplaced { get; set; }
    public bool GearboxReplaced { get; set; }

    public string JobComplete { get; set; }

    public string StaffId { get; set; }
    public string TurbineId { get; set; }

    public virtual Staff Staff { get; set; }

    public virtual Turbine Turbine { get; set; }
}
