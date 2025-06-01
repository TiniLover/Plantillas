using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.PATRONES
{
    public interface IObserver
    {
        void Update(string message);
    }

    public class ConcreteObserver : IObserver
    {
        private string _name;

        public ConcreteObserver(string name) => _name = name;

        public void Update(string message) =>
            Console.WriteLine($"{_name} received: {message}");
    }

    public class Subject
    {
        private List<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer) => _observers.Add(observer);
        public void Detach(IObserver observer) => _observers.Remove(observer);

        public void Notify(string message)
        {
            foreach (var observer in _observers)
                observer.Update(message);
        }
    }

}
