using Coworking.Data.Recources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Data.Providers
{
    internal class DataBaseSingleton
    {
        private static readonly object _lock = new();
        private static IDataBase? _instance;

        public static IDataBase vratiInstancu()
        {
            if(_instance== null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new DataBaseProxy();
                    }
                }
            }
            return _instance;
        }


    }
}
