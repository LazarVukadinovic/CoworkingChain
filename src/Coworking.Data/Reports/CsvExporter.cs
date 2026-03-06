using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Data.Reports
{
    public class CsvExporter
    {
        public void ExportToCsv(List<ReportRow> rows, string filePath)
        {
            var sb = new StringBuilder();

            sb.AppendLine("ClanId,Ime,Prezime,TipClanstva,NazivTipaClanstva,SatiKorisnik,ResursId,NazivResursa,TipResursa");

            foreach (var r in rows)
            {
                sb.AppendLine($"{r.ClanId},\"{r.Ime}\",\"{r.Prezime}\",{r.TipClanstva},\"{r.NazivTipaClanstva}\",{r.SatiKorisnik},{r.ResursId},\"{r.NazivResursa}\",\"{r.TipResursa}\"");
            }

            File.WriteAllText(filePath, sb.ToString(), new System.Text.UTF8Encoding(true));
        }
    }
}
