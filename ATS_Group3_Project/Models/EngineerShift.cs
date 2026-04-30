using System;
using System.ComponentModel.DataAnnotations;
using ATS_Group3_Project;
using System.Data.Entity;

using System.ComponentModel.DataAnnotations.Schema;

public class EngineerShift
{
    [Key]
    [ForeignKey("Staff")]
    public string StaffId { get; set; }

    [Required]
    public string ShiftType { get; set; }  // Early or Late

    public bool Monday { get; set; }
    public bool Tuesday { get; set; }
    public bool Wednesday { get; set; }
    public bool Thursday { get; set; }
    public bool Friday { get; set; }
    public bool Saturday { get; set; }
    public bool Sunday { get; set; }

    public virtual Staff Staff { get; set; }
}