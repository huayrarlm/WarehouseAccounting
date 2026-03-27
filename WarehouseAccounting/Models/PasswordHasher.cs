using System.Security.Cryptography;
using System.Text;

namespace WarehouseAccounting
{
    /// <summary>
    /// ХЭШИПРОВАНИЕ ПАРОЛЕЙ
    /// </summary>
    public static partial class PasswordHasher
    {
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256.ComputeHash(bytes);

                StringBuilder builder = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public static bool VerifyPassword(string password, string hash)
        {
            string hashOfInput = HashPassword(password);
            return hashOfInput == hash;
        }
    }
}
