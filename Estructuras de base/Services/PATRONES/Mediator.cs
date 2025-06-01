using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.PATRONES
{
    public abstract class Mediator
    {
        public abstract void Send(string message, Colleague colleague);
    }

    public abstract class Colleague
    {
        protected Mediator _mediator;

        protected Colleague(Mediator mediator) => _mediator = mediator;
    }

    public class ConcreteColleagueA : Colleague
    {
        public ConcreteColleagueA(Mediator mediator) : base(mediator) { }

        public void Send(string message) => _mediator.Send(message, this);
        public void Notify(string message) => Console.WriteLine($"A received: {message}");
    }

    public class ConcreteColleagueB : Colleague
    {
        public ConcreteColleagueB(Mediator mediator) : base(mediator) { }

        public void Send(string message) => _mediator.Send(message, this);
        public void Notify(string message) => Console.WriteLine($"B received: {message}");
    }

    public class ConcreteMediator : Mediator
    {
        public ConcreteColleagueA ColleagueA { get; set; }
        public ConcreteColleagueB ColleagueB { get; set; }

        public override void Send(string message, Colleague sender)
        {
            if (sender == ColleagueA)
                ColleagueB.Notify(message);
            else
                ColleagueA.Notify(message);
        }
    }

}
