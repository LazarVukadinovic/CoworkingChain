using Coworking.Data.Chain_Of_Responsibility;
using Coworking.Data.Providers;
using Coworking.Domain.Entities;

namespace Coworking.Data.Command.RezervacijaCommand
{
    public class OtkaziRezervacijuCommand : Command
    {
        private Rezervacija _rezervacija;

        public OtkaziRezervacijuCommand(IDataBase proxy, Rezervacija rezervacija) : base(proxy)
        {
            _rezervacija = rezervacija;
        }

        public override ValidationResult CanExecute()
        {
            return ValidationResult.Success();
        }

        public override void Execute() 
        {
            _proxy.otkaziRezervaciju(_rezervacija.rezervacijaId);
            //_proxy.izbrisirezervaciju(_rezervacija.rezervacijaId);
        }

        public override void Undo()
        {
            //_proxy.dodajRezervaciju(_rezervacija);
            _proxy.izmeniRezervaciju(_rezervacija);
        }
    }
}
