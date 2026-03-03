using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Domain.Entities
{
    public class SalaZaSastanke : Resurs
    {
        public int salaId { get; set; }
        public int kapacitet { get; set; }
        public bool imaProjektor { get; set; }
        public bool imaTablu { get; set; }
        public bool imaTv { get; set; }
        public bool imaOpremuZaOnlineSastanke { get; set; }
        public SalaZaSastanke() { }
        public SalaZaSastanke(string? oznaka, string? tipResursa, string? opis, int kapacitet) : base(oznaka, tipResursa, opis)
        {
            this.kapacitet = kapacitet;
            this.imaProjektor = false;
            this.imaTablu = false;
            this.imaTv = false;
            this.imaOpremuZaOnlineSastanke = false;
        }
    }
}
