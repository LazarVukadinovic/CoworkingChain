using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Data.Reports
{
    public class ReportRow
    {
        public int ClanId { get; set; }
        public string Ime { get; set; } = "";
        public string Prezime { get; set; } = "";
        public string TipClanstva { get; set; } = "";
        public double SatiKorisnik { get; set; }
        public int ResursId { get; set; }
        public string NazivResursa { get; set; } = "";
        public string TipResursa { get; set; } = "";
    }
}
