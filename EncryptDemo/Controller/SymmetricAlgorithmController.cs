using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace EncryptDemo.Controller
{
    class SymmetricAlgorithmController<SymmetricAlgorithmType> where SymmetricAlgorithmType : SymmetricAlgorithm, new()
    {
        public string Encypt(string key, string iv, string data)
        {
            byte[] keybytes = ASCIIEncoding.ASCII.GetBytes(key);
            byte[] ivbytes = ASCIIEncoding.ASCII.GetBytes(iv);
            SymmetricAlgorithmType SymmetricCSP = new SymmetricAlgorithmType();
            SymmetricCSP.CreateEncryptor(keybytes,ivbytes);

            MemoryStream ms = new MemoryStream();
            CryptoStream cst = new CryptoStream(ms, SymmetricCSP.CreateEncryptor(keybytes, ivbytes), CryptoStreamMode.Write);
            StreamWriter sw = new StreamWriter(cst);
            sw.Write(data);
            sw.Flush();
            cst.FlushFinalBlock();
            sw.Flush();
            return Convert.ToBase64String(ms.GetBuffer(), 0, (int)ms.Length);
        }

        public string Decypt(string key, string iv, string data)
        {
            byte[] keybytes = ASCIIEncoding.ASCII.GetBytes(key);
            byte[] ivbytes = ASCIIEncoding.ASCII.GetBytes(iv);
            SymmetricAlgorithmType SymmetricCSP = new SymmetricAlgorithmType();
            SymmetricCSP.CreateEncryptor(keybytes, ivbytes);
            byte[] dataByte = Convert.FromBase64String(data);

            MemoryStream ms = new MemoryStream(dataByte);
            CryptoStream cst = new CryptoStream(ms, SymmetricCSP.CreateDecryptor(keybytes, ivbytes), CryptoStreamMode.Read);
            StreamReader sr = new StreamReader(cst);
            return sr.ReadToEnd();
        }
    }
}
