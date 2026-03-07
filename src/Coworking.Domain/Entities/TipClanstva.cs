namespace Coworking.Domain.Entities
{
    public class TipClanstva
    {
        public int tipClanstvaId { get; set; }
        public string? naziv { get; set; }
        public float? cena { get; set; }
        public int? trajanjeDana { get; set; }
        public int? maxSatiRezervacijeMesecno { get; set; }
        public int? satiSaleMesecno { get; set; }
        public bool? dozvoljenaSala { get; set; }

        public TipClanstva()
        {

        }

        public TipClanstva(TipClanstva t)
        {
            this.tipClanstvaId = t.tipClanstvaId;
            this.naziv = t.naziv;
            this.cena= t.cena;
            this.trajanjeDana = t.trajanjeDana;
            this.maxSatiRezervacijeMesecno = t.maxSatiRezervacijeMesecno;
            this.satiSaleMesecno = t.satiSaleMesecno;
            this.dozvoljenaSala=t.dozvoljenaSala;
        }

        public TipClanstva(string? naziv, float? cena, int? trajanjeDana, int? maxSatiRezervacijeMesecno, int? satiSaleMesecno, bool? dozvoljenaSala)
        {
            this.naziv = naziv;
            this.cena = cena;
            this.trajanjeDana = trajanjeDana;
            this.maxSatiRezervacijeMesecno = maxSatiRezervacijeMesecno;
            this.satiSaleMesecno = satiSaleMesecno;
            this.dozvoljenaSala = dozvoljenaSala;
        }

        public override string ToString()
        {
            return $"{tipClanstvaId} {naziv} - {cena}, {trajanjeDana} dana, maksimalno {maxSatiRezervacijeMesecno} sati sale mesecno, za sada {satiSaleMesecno} sati sale mesecno, dozvoljena sala {dozvoljenaSala}";
        }
    }
}
