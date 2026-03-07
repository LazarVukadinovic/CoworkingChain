using Coworking.Data.Providers;
using Coworking.Domain.Entities;

namespace Coworking.Data.Chain_Of_Responsibility
{
    internal abstract class RezervacijaHandler
    {
        protected RezervacijaHandler? _next;
        protected IDataBase _proxy;

        public RezervacijaHandler(IDataBase proxy)
        {
            _proxy = proxy;
        }
        public RezervacijaHandler SetNext(RezervacijaHandler next)
        {
            _next = next;
            return _next;
        }

        public virtual ValidationResult Handle(Rezervacija rezervacija)
        {
            if (_next != null)
                return _next.Handle(rezervacija);
            return ValidationResult.Success();
        }
    }
}
