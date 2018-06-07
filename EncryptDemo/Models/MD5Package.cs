using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EncryptDemo.Models;

namespace EncryptDemo.Models
{
    class MD5Package : EncryptPackage
    {
        public readonly Encoding Encoder = Encoding.UTF8;

        public MD5Package(Encoding encoder)
        {
            Encoder = encoder;
        }
    }
}
