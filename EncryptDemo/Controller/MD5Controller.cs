using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using EncryptDemo.Interfaces;
using EncryptDemo.Models;

namespace EncryptDemo.Controller
{
    class MD5Controller : IEncrypt<string, MD5Package ,string>
    {
        public string Encypt(MD5Package package, string data)
        {
            MD5CryptoServiceProvider MD5CSP = new MD5CryptoServiceProvider();
            byte[] HashBytes = MD5CSP.ComputeHash(package.Encoder.GetBytes(data));
            string HashString = BitConverter.ToString(MD5CSP.ComputeHash(package.Encoder.GetBytes(data))).Replace("-","");
            return HashString;
        }
    }
}
