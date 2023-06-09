﻿using System.Security.Cryptography;
using System.Text;

namespace newTest
{
    internal class HashUtils
    {
        public static string HashString(string stringToHash)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytesToHash = Encoding.UTF8.GetBytes(stringToHash);

                byte[] hashBytes = sha256Hash.ComputeHash(bytesToHash);

                StringBuilder stringBuilder = new StringBuilder();

                for (int i = 0; i < hashBytes.Length; i++)
                {
                    stringBuilder.Append(hashBytes[i].ToString("x2"));
                }

                return stringBuilder.ToString();
            }
        }
    }
}


//return HashFactory.Crypto.CreateSHA2_256()
//.ComputeString(stringToHash, Encoding.UTF8).ToString();