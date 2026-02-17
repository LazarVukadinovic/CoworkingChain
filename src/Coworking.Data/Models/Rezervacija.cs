using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Data.Models
{
    internal class Rezervacija
    {
        public int rezervacijaId { get; set; }
        public int clanId { get; set; }
        public int resursId { get; set; }
        public string? pocetak { get; set; }
        public string? kraj { get; set; }
        public int? status { get; set; }
        public string? kreiranoU { get; set; }
        public string? otkazanoU { get; set; }

        public Rezervacija()
        {

        }

        public Rezervacija(Rezervacija r)
        {
            this.rezervacijaId = r.rezervacijaId;
            this.clanId = r.clanId;
            this.pocetak = r.pocetak;
            this.resursId = r.resursId;
            this.kraj = r.kraj;
            this.status = r.status;
            this.kreiranoU = r.kreiranoU;
            this.otkazanoU = r.otkazanoU;
        }

        public Rezervacija(string? pocetak, string? kraj, int? status,string? kreiranoU, string? otkazanoU)
        {
            this.pocetak = pocetak;
            this.kraj = kraj;
            this.status = status;
            this.kreiranoU = kreiranoU;
            this.otkazanoU = otkazanoU;
        }

        public override string ToString()
        {
            return $"{rezervacijaId} {clanId}, {resursId} - {pocetak}, {kraj}, {status}, {kreiranoU}, {otkazanoU}";
        }
    }
}
