using System;
using System.IO;
using System.Security.Cryptography;

namespace CitizenFXRemapper.Classes
{
    internal class Filehelper
    {
        internal static string GetSha256(string Filepath)
        {
            using (SHA256 SHA256 = SHA256Managed.Create())
            {
                using (FileStream fileStream = File.OpenRead(Filepath))
                    return Convert.ToBase64String(SHA256.ComputeHash(fileStream));
            }
        }
    }
}