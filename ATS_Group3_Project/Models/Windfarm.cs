using ATS_Group3_Project;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;


public class WindFarm
{
    [Key]
    public int FarmId { get; set; }

    [Required]
    [StringLength(100)]
    public string FarmName { get; set; }

    [Required]
    public string Address1 { get; set; }

    public string Address2 { get; set; }

    [Required]
    public string City { get; set; }

    [Required]
    public string Postcode { get; set; }

    [Required]
    public string Region { get; set; }

    // Navigation Property
    public virtual ICollection<Turbine> Turbines { get; set; }

    public WindFarm()
    {
        Turbines = new List<Turbine>();
    }
}
