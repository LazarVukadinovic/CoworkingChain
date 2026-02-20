using Coworking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;

namespace Coworking.Data.Providers
{
    internal class ResursRepository : IRepository<Resurs>
    {
        private readonly string konekcioniString;
        private readonly DataBaseAdapter adapter;
        private readonly DataBaseMapper mapper;

        public ResursRepository()
        {
            var path = Path.Combine(AppContext.BaseDirectory, "config.txt");
            konekcioniString = File.ReadAllLines(path)[1];

            var helper = new DataBaseFactory();
            var factory = helper.vratiFactory(konekcioniString);

            adapter = new DataBaseAdapter(factory, konekcioniString);
            mapper = new DataBaseMapper();
        }
        public void Add(Resurs item)
        {
            string upit = $@"
            INSERT INTO resurs (lokacija_id, oznaka, tip_resursa, opis)
            VALUES (
                '{item.lokacijaId}',
                '{item.oznaka}',
                '{item.tipResursa}',
                '{item.opis}'
            );";

            adapter.izvrsiUpitBezRezultata(upit);

        }

        public List<Resurs> GetAll()
        {
            string upit = "SELECT * FROM resurs";
            return mapper.mapDataTable(adapter.izvrsiUpit(upit), mapper.mapResurs);
        }

        public List<Resurs> GetResourcesByLocation(int locationId)
        {
            string upit = $@"
            SELECT r.*
            FROM resurs r
            WHERE r.lokacija_id = {locationId}
            ORDER BY r.tip_resursa";


            return mapper.mapDataTable(adapter.izvrsiUpit(upit), mapper.mapResurs);
        }

        public void Update(Resurs item)
        {
            string upit = $@"
            UPDATE resurs
            SET 
                lokacija_id = '{item.lokacijaId}',
                oznaka = '{item.oznaka}',
                tip_resursa = '{item.tipResursa}',
                opis = '{item.opis}'
            WHERE resurs_id = {item.resursId};";

            adapter.izvrsiUpitBezRezultata(upit);
        }

        public List<RadnoMesto> prikaziRadnaMestaPoLokaciji(int lokacijaId)
        {
            string upit = $@"
            SELECT r.*,rmd.podtip CASE 
                WHEN rv.pocetak<SYSDATETIME() AND rv.kraj>SYSDATETIME() and rv.status!='Otkazan' THEN 'Zauzeto'
                ELSE 'Dostupno'
                END AS dostupnost
            FROM radno_mesto_detalj rmd
            JOIN resurs r on rmd.resurs_id=r.resurs_id
            JOIN rezervacija rv on rv.resurs_id=r.resurs_id
            WHERE r.lokacija_id = {lokacijaId}";

            return mapper.mapDataTable(adapter.izvrsiUpit(upit), mapper.mapRadnoMesto);
        }

        public List<SalaZaSastanke> prikaziSaleZaSastanke()
        {
            string upit = $@"
            SELECT r.*,s.sala_id,s.kapacitet,s.ima_projektor,s.ima_tv,s.ima_tablu,s.ima_online_opremu
            FROM sala_detalj s
            JOIN resurs r on r.resurs_id=s.resurs_id";

            return mapper.mapDataTable(adapter.izvrsiUpit(upit), mapper.mapSalaZaSastanke);
        }
    }
}
