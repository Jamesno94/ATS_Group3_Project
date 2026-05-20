using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class User
{
    [Key]
    public int UserId { get; set; }

    [Required]
    public string StaffId { get; set; }

    [Required]
    public string PasswordHash { get; set; }

    [Required]
    public string PasswordSalt { get; set; }

    public int FailedLoginAttempts { get; set; }

    public bool IsLocked { get; set; }

    public string PasswordResetCode { get; set; }

    public DateTime? PasswordResetExpiry { get; set; }

    [ForeignKey("StaffId")]
    public virtual Staff Staff { get; set; }
}