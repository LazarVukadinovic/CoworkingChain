using Coworking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Data.Repositories
{
    internal interface IAdminRepository
    {
        Admin getAdminByUsername(string username);
        void addAdmin(Admin admin);
    }
}
