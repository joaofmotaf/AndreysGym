using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace AndreysGym.Entidades
{
    [Index(nameof(Email), IsUnique = true)]
    public class Credencial
    {
        private const String SALT = "54321AnCaJoMa";
        public UInt64 Id { get; set; }
        [Required, MaxLength(255)]
        public String Email { get; set; }
        [Required, MaxLength(64)]
        private String _senha;
        public String Senha
        {
            get
            {
                return _senha;
            }
            set
            {
                _senha = ComputeSHA256(value, SALT);
            }
        }
        public Boolean Admin { get; set; }
        [Required]
        public Usuario Usuario { get; set; }
        [Required]
        public UInt64 UsuarioId { get; set; }
        private String ComputeSHA256(String input)
        {
            return ComputeSHA256(input, null);
        }
        public static String ComputeSHA256(String input, String salt)
        {
            String hash = String.Empty;

            // 
            // https://learn.microsoft.com/en-us/dotnet/standard/security/cryptographic-services
            // https://learn.microsoft.com/en-us/dotnet/api/system.security.cryptography.sha256?view=netframework-4.8
            // https://www.techiedelight.com/generate-sha-256-hash-of-string-csharp/
            // 

            // Initialize a SHA256 hash object
            using (SHA256 sha256 = SHA256.Create())
            {
                // Compute the hash of the given string
                byte[] hashValue = sha256.ComputeHash(
                    Encoding.UTF8.GetBytes(salt + input));

                // Convert the byte array to string format
                foreach (byte b in hashValue)
                {
                    hash += $"{b:X2}";
                }
            }

            return hash;
        }
    }
}
