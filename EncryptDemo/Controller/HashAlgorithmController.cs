using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace EncryptDemo.Controller
{
    class HashAlgorithmController<HashAlgorithmType> where HashAlgorithmType: HashAlgorithm, new()
    {
        public string Encypt(Encoding encoder, string data)
        {
            HashAlgorithmType HashCSP = new HashAlgorithmType();
            byte[] HashBytes = HashCSP.ComputeHash(encoder.GetBytes(data));
            string HashString = BitConverter.ToString(HashBytes).Replace("-","");
            return HashString;
        }
    }
}
