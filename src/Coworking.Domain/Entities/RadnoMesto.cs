using Coworking.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Domain.Entities
{
    public class RadnoMesto : Resurs
    {
        public int radnoMestoId { get; set; }
        public PodtipRadnogMesta podtip { get; set; }
        public RadnoMesto() { }
        public RadnoMesto(string? oznaka, string? tipResursa, string? opis) : base(oznaka, tipResursa, opis)
        {

        }

    }
}
