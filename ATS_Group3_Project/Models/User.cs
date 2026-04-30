using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using ATS_Group3_Project;

public class User
{
    [Key]
    public int UserId { get; set; }

    public string StaffId { get; set; }

    [Required]
    public string PasswordHash { get; set; }

    [Required]
    public string PasswordSalt { get; set; }

    public virtual Staff Staff { get; set; }
}
