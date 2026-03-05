using Coworking.Domain.Entities;
using Coworking.Domain.Enums;

namespace Coworking.Services.Builders
{
    public class RadnoMestoBuilder : IResursBuilder<RadnoMesto>
    {
        private RadnoMesto _resurs = new();

        public void Reset()
        {
            _resurs = new RadnoMesto();
        }

        public void SetLokacijaId(int lokacijaId)
        {
            _resurs.lokacijaId = lokacijaId;
        }

        public void SetOznaka(string oznaka)
        {
            _resurs.oznaka = oznaka;
        }

        public void SetOpis(string opis)
        {
            _resurs.opis = opis;
        }

        public void SetPodtip(PodtipRadnogMesta podtip)
        {
            _resurs.podtip = podtip;
        }

        public void SetTipResursa()
        {
            _resurs.tipResursa = "radno_mesto";
        }

        public RadnoMesto Build()
        {
            return _resurs;
        }
    }
}
