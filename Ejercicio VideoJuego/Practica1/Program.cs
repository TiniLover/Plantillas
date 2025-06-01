using System;
using DAL;
using Services;
using Domain;


namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var repository = new InMemoryRepository<Entity>();
            var service = new EntityService(repository);

            service.CreateEntity(1, "Velocidad");
            service.CreateEntity(2, "Jugador");
            service.CreateEntity(3, "Salud");

            var entities = service.GetAll();

            Console.WriteLine("Entidades creadas:");
            foreach (var e in entities)
            {
                Console.WriteLine("ID: " + e. salud+ " - Nombre: " + e.jugador);
            }

            Console.ReadLine();
        }
    }
}
