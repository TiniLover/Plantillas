using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.PATRONES
{
    public interface ISubject
    {
        void Request();
    }

    public class RealSubject : ISubject
    {
        public void Request() => Console.WriteLine("RealSubject handling request");
    }

    public class Proxy : ISubject
    {
        private RealSubject _realSubject;

        public void Request()
        {
            if (_realSubject == null)
                _realSubject = new RealSubject();

            Console.WriteLine("Proxy delegating to RealSubject");
            _realSubject.Request();
        }
    }

}
