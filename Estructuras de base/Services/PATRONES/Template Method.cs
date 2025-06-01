using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.PATRONES
{
    public abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            Step1();
            Step2();
            Hook();
        }

        protected abstract void Step1();
        protected abstract void Step2();

        protected virtual void Hook() { }
    }

    public class ConcreteClass : AbstractClass
    {
        protected override void Step1() => Console.WriteLine("Step1 implementation");
        protected override void Step2() => Console.WriteLine("Step2 implementation");
    }

}
