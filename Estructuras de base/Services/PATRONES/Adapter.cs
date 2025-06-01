using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.PATRONES
{
    public interface ITarget
    {
        void Request();
    }

    public class Adaptee
    {
        public void SpecificRequest() => Console.WriteLine("Called SpecificRequest()");
    }

    public class Adapter : ITarget
    {
        private Adaptee _adaptee = new Adaptee();

        public void Request() => _adaptee.SpecificRequest();
    }

}
