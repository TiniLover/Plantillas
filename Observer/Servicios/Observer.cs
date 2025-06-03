using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Domain;

namespace Servicios
{
    public class Observer
    {
        private IRepository<Entity> _repository;
        private Entity _manager;
        private Subject _subject;

        public Observer(IRepository<Entity> repository)
        {
            _repository = repository;
            _manager = new Entity();
            _subject = new Subject();
        }

        public bool CreateEntity(int id, string noticia)
        {
            var entity = new Entity
            {
                Id = id,
                Noticia = noticia// categoria
            };
            _subject.Notify(entity.Noticia);

            if (!managerIsValid(entity))
                return false;

            _repository.Add(entity);
            return true;
        }

        public List<Entity> GetAll()
        {
            return _repository.GetAll();
        }
        public interface IObserver
        {
            void Update(string message);
        }

        public class ConcreteObserver : IObserver
        {
            private string _notificacion;

            private string _nombre;
            private string _categoriaInteres;

            public ConcreteObserver(string nombre, string categoriaInteres)
            {
                _nombre = nombre;
                _categoriaInteres = categoriaInteres;
            }

            public void Update(string message)// actualizar / mandar a los subs la notificacion
            {
                if (message.Equals(_categoriaInteres, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"{_nombre} recibió una noticia de su interés: {message}");
                }
            }
        }

        public class Subject //guardo la lista de observers
        {
            private List<IObserver> _observers = new List<IObserver>();

            public void Attach(IObserver observer) => _observers.Add(observer);// suscribir
            public void Detach(IObserver observer) => _observers.Remove(observer);// desuscribir

            public void Notify(string message) // notifica a los subs
            {
                foreach (var observer in _observers)
                    observer.Update(message);
            }
        }
        private bool ManagerIsValid(Entity entity)
        {

            return entity != null && !string.IsNullOrWhiteSpace(entity.Noticia);
        }
        private bool managerIsValid(Entity entity)
        {

            return entity != null && !string.IsNullOrWhiteSpace(entity.Noticia);
        }

        

       

        public void AgregarObservador(IObserver observer)
        {
            _subject.Attach(observer);
        }


    }
}
