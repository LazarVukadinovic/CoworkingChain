using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Data.Models
{
    internal class Clan
    {
        public int clanId { get; set; }
        public string? ime { get; set; }
        public string? prezime { get; set; }
        public string? mail { get; set; }
        public string? brTelefona { get; set; }
        public string? tipClanstva { get; set; }
        public string? datumPocetka { get; set; }
        public string? datumKraja { get; set; }
        public string? statusNaloga { get; set; }
        public string? kreiran {  get; set; }

        public Clan()
        {

        }

        public Clan(Clan c)
        {
            this.clanId = c.clanId;
            this.ime = c.ime;
            this.prezime = c.prezime;
            this.mail = c.mail;
            this.brTelefona = c.brTelefona;
            this.tipClanstva = c.tipClanstva;
            this.datumPocetka = c.datumPocetka;
            this.datumKraja = c.datumKraja;
            this.statusNaloga = c.statusNaloga;
            this.kreiran = c.kreiran;
        }

        public Clan(string? ime, string? prezime, string? mail, string? brTel, string? tipCl, string? datPoc, string? datKr, string? stNal,string? kreiran)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.mail = mail;
            this.brTelefona = brTel;
            this.tipClanstva = tipCl;
            this.datumPocetka = datPoc;
            this.datumKraja = datKr;
            this.statusNaloga = stNal;
            this.kreiran=kreiran;
        }

        public override string ToString()
        {
            return $"{clanId} {ime} {prezime} - {mail}, {brTelefona}, {tipClanstva}, {datumPocetka}, {datumKraja}, {statusNaloga},{kreiran}";
        }
    }
}
