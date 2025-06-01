using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.PATRONES
{
    public interface IComponent
    {
        void Operation();
    }

    public class ConcreteComponent : IComponent
    {
        public void Operation() => Console.WriteLine("ConcreteComponent Operation");
    }

    public class Decorator : IComponent
    {
        protected IComponent _component;

        public Decorator(IComponent component)
        {
            _component = component;
        }

        public virtual void Operation() => _component.Operation();
    }

    public class ConcreteDecorator : Decorator
    {
        public ConcreteDecorator(IComponent component) : base(component) { }

        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("ConcreteDecorator added behavior");
        }
    }

}
