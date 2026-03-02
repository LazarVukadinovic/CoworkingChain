using Coworking.Data.Chain_Of_Responsibility;
using Coworking.Data.Providers;
using Coworking.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coworking.Data.Command.RezervacijaCommand
{
    internal class DodajRezervacijuCommand : Command
    {
        private Rezervacija _rezervacija;
        private RezervacijaHandler _validatorChain;

        public DodajRezervacijuCommand(IDataBase proxy, Rezervacija rezervacija) : base(proxy)
        {
            _rezervacija = rezervacija;

            var zauzetostResursaValidator = new ZauzetostResursaValidator(proxy);
            var limitSatiClanValidator = new LimitSatiClanValidator(proxy);
            var radnoVremeLokacijeValidator = new RadnoVremeLokacijeValidator(proxy);

            zauzetostResursaValidator.SetNext(limitSatiClanValidator).SetNext(radnoVremeLokacijeValidator);
            _validatorChain = zauzetostResursaValidator;
        }

        public override ValidationResult CanExecute()
        {
            return _validatorChain.Handle(_rezervacija);
        }

        public override void Execute()
        {
            _proxy.dodajRezervaciju(_rezervacija);
        }

        public override void Undo()
        {
            _proxy.otkaziRezervaciju(_rezervacija.rezervacijaId);
            //_proxy.izbrisiRezervaciju(_rezervacija.rezervacijaId);
        }
    }
}