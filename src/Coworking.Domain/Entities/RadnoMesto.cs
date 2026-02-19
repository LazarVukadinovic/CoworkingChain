using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Domain.Entities
{
    public enum PodtipRadnogMesta
    {
        hot_desk,
        dedicated_desk,
        private_office
    }
    public class RadnoMesto : Resurs
    {
        public PodtipRadnogMesta podtip { get; set; }
        public RadnoMesto() { }
        public RadnoMesto(string? oznaka, string? tipResursa, string? opis) : base(oznaka, tipResursa, opis)
        {

        }

    }
}
