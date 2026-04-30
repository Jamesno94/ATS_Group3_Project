using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using ATS_Group3_Project;


public class Staff
{
    [Key]
    public string StaffId { get; set; }

    [Required]
    public string FirstName { get; set; }

    [Required]
    public string LastName { get; set; }

    [Required]
    public string WorkMobile { get; set; }

    public string HomeMobile { get; set; }

    [Required]
    public string Email { get; set; }

    [Required]
    public string Address1 { get; set; }

    public string Address2 { get; set; }

    [Required]
    public string City { get; set; }

    [Required]
    public string Postcode { get; set; }

    [Required]
    public decimal Salary { get; set; }

    [Required]
    public string Role { get; set; }

    public virtual EngineerShift EngineerShift { get; set; }

    public virtual ICollection<JobRecord> Jobs { get; set; }

    public Staff()
    {
        Jobs = new List<JobRecord>();
    }
}

