using Coworking.Data.Chain_Of_Responsibility;

namespace Coworking.Data.Command
{
    public class CommandManager
    {
        private Stack<Command> history;

        public CommandManager()
        {
            history = new Stack<Command>();
        }

        public ValidationResult ExecuteCommand(Command command)
        {
            var result = command.CanExecute();
            if (result.isValid == true)
            {
                command.Execute();
                history.Push(command);
            }
            return result;
        }

        public void UndoLast()
        {
            if (history.Count > 0)
            {
                var command = history.Pop();
                command.Undo();
            }
        }
    }
}