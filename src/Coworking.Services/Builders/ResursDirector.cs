using Coworking.Domain.Entities;
using Coworking.Domain.Enums;

namespace Coworking.Services.Builders
{
    public class ResursDirector
    {
        public RadnoMesto BuildRadnoMesto(
            RadnoMestoBuilder builder,
            int lokacijaId,
            string oznaka,
            string opis,
            int resursId,
            PodtipRadnogMesta podtip)
        {
            builder.Reset();
            builder.SetLokacijaId(lokacijaId);
            builder.SetResursId(resursId);
            builder.SetOznaka(oznaka);
            builder.SetOpis(opis);
            builder.SetTipResursa();
            builder.SetPodtip(podtip);

            return builder.Build();
        }

        public SalaZaSastanke BuildSala(
            SalaZaSastankeBuilder builder,
            int lokacijaId,
            string oznaka,
            string opis,
            int resursId,
            int kapacitet,
            bool imaProjektor,
            bool imaTablu,
            bool imaTv,
            bool imaOnlineOpremu)
        {
            builder.Reset();
            builder.SetLokacijaId(lokacijaId);
            builder.SetOznaka(oznaka);
            builder.SetOpis(opis);
            builder.SetTipResursa();
            builder.SetResursId(resursId);
            builder.SetKapacitet(kapacitet);
            builder.SetImaProjektor(imaProjektor);
            builder.SetImaTablu(imaTablu);
            builder.SetImaTv(imaTv);
            builder.SetImaOnlineOpremu(imaOnlineOpremu);

            return builder.Build();
        }
    }
}
