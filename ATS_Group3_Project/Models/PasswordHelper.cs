using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using ATS_Group3_Project;



public class PasswordHelper
{
    public static (string hash, string salt) HashPassword(string password)
    {
        // Create random salt
        byte[] saltBytes = new byte[16];

        using (var rng = RandomNumberGenerator.Create())
        {
            rng.GetBytes(saltBytes);
        }

        // Create PBKDF2 hash
        var pbkdf2 = new Rfc2898DeriveBytes(
            password,
            saltBytes,
            100000,
            HashAlgorithmName.SHA256
        );

        byte[] hashBytes = pbkdf2.GetBytes(32);

        return
        (
            Convert.ToBase64String(hashBytes),
            Convert.ToBase64String(saltBytes)
        );
    }

    public static bool VerifyPassword(
        string enteredPassword,
        string storedHash,
        string storedSalt)
    {
        byte[] saltBytes =
            Convert.FromBase64String(storedSalt);

        var pbkdf2 = new Rfc2898DeriveBytes(
            enteredPassword,
            saltBytes,
            100000,
            HashAlgorithmName.SHA256
        );

        byte[] hashBytes = pbkdf2.GetBytes(32);

        string enteredHash =
            Convert.ToBase64String(hashBytes);

        return enteredHash == storedHash;
    }
}