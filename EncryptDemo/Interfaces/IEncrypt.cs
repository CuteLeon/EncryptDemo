using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EncryptDemo.Models;

namespace EncryptDemo.Interfaces
{
    interface IEncrypt<DataType, PackageType, OutType> where PackageType : EncryptPackage
    {
        OutType Encypt(PackageType package, DataType data);
    }
}
