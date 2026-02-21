using Coworking.Domain.Entities;
using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;
using Microsoft.IdentityModel.Tokens;

namespace Coworking.Data.Providers
{
    public class AdminRepository : IAdminRepository
    {
        private readonly DataBaseAdapter _adapter;
        private readonly DataBaseMapper _mapper;

        public AdminRepository(DataBaseAdapter adapter, DataBaseMapper mapper)
        {
            _adapter = adapter;
            _mapper = mapper;
        }
        public void addAdmin(Admin admin)
        {
            string upit = $@"
            INSERT INTO admin_korisnik (korisnicko_ime, lozinka_hash)
            VALUES (
                '{admin.KorisnickoIme}',
                '{admin.LozinkaHash}'
            );";
            _adapter.izvrsiUpitBezRezultata(upit);
        }

        public Admin getAdminByUsername(string username)
        {
            string upit = $@"
            SELECT * FROM admin_korisnik
            WHERE korisnicko_ime = '{username}';
            ";
            var result = _mapper.mapDataTable(_adapter.izvrsiUpit(upit), _mapper.mapAdmin);
            return result.IsNullOrEmpty() ? null : result[0];
        }
    }
}
