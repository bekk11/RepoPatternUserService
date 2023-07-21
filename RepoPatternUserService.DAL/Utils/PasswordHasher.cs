using System.Security.Cryptography;

namespace RepoPatternUserService.DAL.Utils;

public class PasswordHasher
{
    [Obsolete("Obsolete")]
    public static byte[] GenerateSalt()
    {
        byte[] salt = new byte[16];

        using (var rng = new RNGCryptoServiceProvider())
        {
            rng.GetBytes(salt);
        }

        return salt;
    }
    [Obsolete("Obsolete")]
    public static byte[] HashPassword(string password, byte[] salt)
    {
        using (var deriveBytes = new Rfc2898DeriveBytes(password, salt, 10000))
        {
            return deriveBytes.GetBytes(32); // Replace 32 with the desired hash length in bytes
        }
    }
}