using Coworking.Data.Chain_Of_Responsibility;
using Coworking.Data.Providers;

namespace Coworking.Data.Command
{
    public abstract class Command
    {
        protected IDataBase _proxy;

        public Command(IDataBase proxy)
        {
            _proxy = proxy;
        }

        public abstract ValidationResult CanExecute();
        public abstract void Execute();
        public abstract void Undo();
    }
}