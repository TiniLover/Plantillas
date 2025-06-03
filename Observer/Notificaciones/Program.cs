using System;
using Dal;
using Servicios;
using Domain;
using BLL;
using static Servicios.Observer;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //creando suscripcion
            var repository = new Dao<Entity>();
            var service = new Observer(repository);//creamos observer
            Console.WriteLine("Ingresar Nombre");//ingresa nombre
            string nombre = Console.ReadLine();// le
            Console.WriteLine("Ingresar Categoria");//Ingresa Humor , Pesca
            string categoria = Console.ReadLine();
            // Clientes interesados en distintas categorías
            service.AgregarObservador(new Observer.ConcreteObserver(nombre, categoria));//donde dice agregar observador estamos "suscribiendo"
            


            // Se crean entidades que disparan notificaciones
            service.CreateEntity(1, "Humor"); //creo la noticia que manda la notificacion
            service.CreateEntity(2, "Pesca");
            service.CreateEntity(1, "Pesca");
            service.CreateEntity(2, "Humor");
            service.CreateEntity(3, "Deportes");

            var entities = service.GetAll();

            Console.WriteLine("Entidades creadas:");
            foreach (var e in entities)
            {
                Console.WriteLine("ID: " + e.Id + " - Noticia: " + e.Noticia);
            }
            Console.ReadLine();
          
            Console.ReadLine();
        }
    }
}
