using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Data.Models
{
    internal class Resurs
    {
        public int resursId { get; set; }
        public int lokacijaId { get; set; }
        public string? oznaka { get; set; }
        public string? tipResursa { get; set; }
        public string? opis { get; set; }
        public int? aktivan { get; set; }

        public Resurs()
        {

        }

        public Resurs(Resurs r)
        {
            this.resursId=r.resursId;
            this.lokacijaId=r.lokacijaId;
            this.oznaka=r.oznaka;
            this.tipResursa=r.tipResursa;
            this.opis=r.opis;
            this.aktivan=r.aktivan;
        }

        public Resurs(string? oznaka, string? tipResursa, string? opis, int? aktivan)
        {
            this.oznaka = oznaka;
            this.tipResursa = tipResursa;
            this.opis = opis;
            this.aktivan = aktivan;
        }

        public override string ToString()
        {
            return $"{resursId} {lokacijaId} - {oznaka}, {tipResursa}, {opis}, {aktivan}";
        }

    }
}
