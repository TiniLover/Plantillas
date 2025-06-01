using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Services;

namespace Services.Services
{
    public class Memento
    {
        private string _state;

        public Memento(string state)
        {
            _state = state;
        }

        public string GetState()
        {
            return _state;
        }
    }
    public class Originator
    {
        private string _state;

        public void SetState(string state)
        {
            _state = state;
            Console.WriteLine("Estado actual: " + _state);
        }


        public string GetState()
        {
            return _state;
        }
    
     public Memento SaveState()
        {
            return new Memento(_state);
        }
    
    public void RestoreState(Memento memento)
        {
            _state = memento.GetState();
            Console.WriteLine("Estado restaurado: " + _state);
        }
    }
    public class Caretaker
    {
        private Memento _memento;

        public void SaveState(Originator originator)
        {
            _memento = originator.SaveState();
        }

        public void RestoreState(Originator originator)
        {
            originator.RestoreState(_memento);
        }
    }
}

