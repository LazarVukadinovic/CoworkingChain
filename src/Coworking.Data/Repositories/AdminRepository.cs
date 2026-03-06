using Coworking.Domain.Entities;
using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;
using Microsoft.IdentityModel.Tokens;
using Coworking.Data.Providers;

namespace Coworking.Data.Repositories
{
    internal class AdminRepository : IRepository<Admin>
    {
        private readonly DataBaseAdapter _adapter;
        private readonly DataBaseMapper _mapper;

        public AdminRepository(DataBaseAdapter adapter, DataBaseMapper mapper)
        {
            _adapter = adapter;
            _mapper = mapper;
        }

        public void Add(Admin admin)
        {
            string upit = $@"
            INSERT INTO admin_korisnik (korisnicko_ime, lozinka_hash)
            VALUES (
                '{admin.KorisnickoIme}',
                '{admin.LozinkaHash}'
            );";
            _adapter.izvrsiUpitBezRezultata(upit);
        }

        public void Delete(int id)
        {
            string upit = $@"DELETE FROM admin_korisnik
            WHERE admin_id = {id};";
            _adapter.izvrsiUpitBezRezultata(upit);
        }

        public List<Admin> GetAll()
        {
            string upit = "SELECT * FROM admin_korisnik;";
            var result = _mapper.mapDataTable(_adapter.izvrsiUpit(upit), _mapper.mapAdmin);
            return result;
        }

        public Admin GetById(int id)
        {
            string upit = $@"
            SELECT * FROM admin_korisnik
            WHERE admin_id = {id};";
            var result = _mapper.mapDataTable(_adapter.izvrsiUpit(upit), _mapper.mapAdmin);
            return result.FirstOrDefault();
        }

        public List<Admin> GetByName(string name)
        {
            string upit = $@"
            SELECT * FROM admin_korisnik
            WHERE korisnicko_ime = '{name}';
            ";
            var result = _mapper.mapDataTable(_adapter.izvrsiUpit(upit), _mapper.mapAdmin);
            return result;
        }

        public void Update(Admin item)
        {
            string upit = $@"UPDATE admin_korisnik
            SET korisnicko_ime = '{item.KorisnickoIme}',
                lozinka_hash = '{item.LozinkaHash}'
            WHERE admin_id = {item.adminId};";
            _adapter.izvrsiUpitBezRezultata(upit);
        }

        public void UpdateAdminByUsername(Admin admin, string newName)
        {
            string upit = $"UPDATE admin_korisnik SET korisnicko_ime = '{newName}' WHERE admin_id = {admin.adminId}";
            _adapter.izvrsiUpitBezRezultata(upit);
        }
    }
}
