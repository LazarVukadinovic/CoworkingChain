using Coworking.Data.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Data.Providers
{
    internal class DataBaseHelper
    {
        public IDataBaseFactory? vratiFactory(string konekcioniString)
        {
            konekcioniString = konekcioniString.ToLower();
            if (konekcioniString.Contains("user id") && konekcioniString.Contains("password"))
            {
                return new MySqlFactory();
            }
            else if (konekcioniString.Contains("trusted_connection") || konekcioniString.Contains("trustservercertificate"))
            {
                return new MsSqlFactory();
            }
            else return null;
        }
    }
}
