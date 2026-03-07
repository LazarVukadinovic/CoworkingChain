using Coworking.Data.Chain_Of_Responsibility;
using Coworking.Data.Providers;
using Coworking.Domain.Entities;

namespace Coworking.Data.Command.RezervacijaCommand
{
    public class IzmeniRezervacijuCommand : Command
    {
        private Rezervacija _rezervacija;
        private Rezervacija _backup;
        private RezervacijaHandler _validatorChain;

        public IzmeniRezervacijuCommand(IDataBase proxy, Rezervacija rezervacija, Rezervacija backup) : base(proxy)
        {
            _rezervacija = rezervacija;
            _backup = backup;

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
            _proxy.izmeniRezervaciju(_rezervacija);
        }

        public override void Undo()
        {
            _proxy.izmeniRezervaciju(_backup);
        }
    }
}
