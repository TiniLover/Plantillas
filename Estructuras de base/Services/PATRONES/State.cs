using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.PATRONES
{
    public interface IState
    {
        void Handle(Context context);
    }

    public class ConcreteStateA : IState
    {
        public void Handle(Context context)
        {
            Console.WriteLine("State A");
            context.State = new ConcreteStateB();
        }
    }

    public class ConcreteStateB : IState
    {
        public void Handle(Context context)
        {
            Console.WriteLine("State B");
            context.State = new ConcreteStateA();
        }
    }

    public class Context
    {
        public IState State { get; set; }

        public Context(IState state) => State = state;

        public void Request() => State.Handle(this);
    }

}
