using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Domain.Entities
{
    public class Lokacija
    {
        public int lokacijaId { get; set; }
        public string? naziv { get; set; }
        public string? adresa { get; set; }
        public string? grad { get; set; }
        public string? radnoVreme { get; set; }
        public int? maxKapacitet { get; set; }
        public string? opis { get; set; }

        public Lokacija()
        {

        }

        public Lokacija(Lokacija l)
        {
            this.lokacijaId = l.lokacijaId;
            this.naziv = l.naziv;
            this.adresa = l.adresa;
            this.grad = l.grad;
            this.radnoVreme = l.radnoVreme;
            this.maxKapacitet = l.maxKapacitet;
            this.opis = l.opis;
        }

        public Lokacija(string? naziv, string? adresa, string? grad, string? radnoVreme, int? maxKapacitet, string? opis)
        {
            this.naziv = naziv;
            this.adresa = adresa;
            this.grad = grad;
            this.radnoVreme = radnoVreme;
            this.maxKapacitet = maxKapacitet;
            this.opis = opis;

        }

        public override string ToString()
        {
            return $"{lokacijaId} {naziv} - {adresa}, {grad}, {radnoVreme}, {maxKapacitet}, {opis}";
        }
    }
}
