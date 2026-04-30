using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using ATS_Group3_Project;
using System.Collections.Generic;

public class Turbine
{
    [Key]
    public string TurbineId { get; set; }

    public string Make { get; set; }

    public string Model { get; set; }

    [Required]
    public int RuntimeHours { get; set; }

    [Required]
    public string Status { get; set; }

    // Foreign Key
    public int FarmId { get; set; }

    [ForeignKey("FarmId")]
    public virtual WindFarm WindFarm { get; set; }
}
