using Coworking.Domain.Entities;

namespace Coworking.Services.Builders
{
    public class SalaZaSastankeBuilder : IResursBuilder<SalaZaSastanke>
    {
        private SalaZaSastanke _resurs = new();

        public void Reset()
        {
            _resurs = new SalaZaSastanke();
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
        public void SetResursId(int resursId)
        {
            _resurs.resursId = resursId;
        }
        public void SetKapacitet(int kapacitet)
        {
            _resurs.kapacitet = kapacitet;
        }

        public void SetImaProjektor(bool imaProjektor)
        {
            _resurs.imaProjektor = imaProjektor;
        }

        public void SetImaTablu(bool imaTablu)
        {
            _resurs.imaTablu = imaTablu;
        }

        public void SetImaTv(bool imaTv)
        {
            _resurs.imaTv = imaTv;
        }

        public void SetImaOnlineOpremu(bool imaOnlineOpremu)
        {
            _resurs.imaOpremuZaOnlineSastanke = imaOnlineOpremu;
        }

        public void SetTipResursa()
        {
            _resurs.tipResursa = "sala";
        }

        public SalaZaSastanke Build()
        {
            return _resurs;
        }
    }
}
