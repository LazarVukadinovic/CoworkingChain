using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Data.Providers
{
    public class DataBaseSingleton
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
                        var settings = new DBSettings();
                        var _facade = new DataBaseFacade(settings);
                        _instance = new DataBaseProxy(_facade);
                    }
                }
            }
            return _instance;
        }


    }
}
