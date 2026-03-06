using Coworking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Data.Providers
{
    public sealed class AdminSession
    {
        private static AdminSession _instance;
        private static readonly object _lock = new object();

        public Admin TrenutniAdmin { get; private set; }

        private AdminSession() { }

        public static AdminSession Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null) _instance = new AdminSession();
                    return _instance;
                }
            }
        }

        public void PrijaviAdmina(Admin admin)
        {
            TrenutniAdmin = admin;
        }

        public void OdjaviAdmina()
        {
            TrenutniAdmin = null;
        }
    }
}
