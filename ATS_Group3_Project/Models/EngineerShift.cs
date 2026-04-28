using System;
using System.ComponentModel.DataAnnotations;
using ATS_Group3_Project;
using System.Data.Entity;

public class EngineerShift
{
    [Key]
    public int ShiftId { get; set; }

    public string StaffId { get; set; }

    public string ShiftType { get; set; }

    public bool Monday { get; set; }
    public bool Tuesday { get; set; }
    public bool Wednesday { get; set; }
    public bool Thursday { get; set; }
    public bool Friday { get; set; }
    public bool Saturday { get; set; }
    public bool Sunday { get; set; }

    public virtual Staff Staff { get; set; }
}
