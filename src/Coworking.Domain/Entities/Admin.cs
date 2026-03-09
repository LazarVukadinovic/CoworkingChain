namespace Coworking.Domain.Entities
{
    public class Admin
    {
        public int adminId { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }

        public Admin() { }
        public Admin(string KorisnickoIme, string LozinkaHash)
        {
            this.KorisnickoIme = KorisnickoIme;
            this.LozinkaHash = LozinkaHash;
        }
    }
}
