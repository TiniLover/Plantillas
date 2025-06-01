using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.PATRONES
{
    public interface ICommand
    {
        void Execute();
    }

    public class Receiver
    {
        public void Action() => Console.WriteLine("Action executed");
    }

    public class ConcreteCommand : ICommand
    {
        private Receiver _receiver;

        public ConcreteCommand(Receiver receiver) => _receiver = receiver;

        public void Execute() => _receiver.Action();
    }

    public class Invoker
    {
        private ICommand _command;

        public void SetCommand(ICommand command) => _command = command;

        public void Run() => _command.Execute();
    }

}
