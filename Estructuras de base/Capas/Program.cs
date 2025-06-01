using System;
using Dal;
using Entities;
using Services;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var repository = new InMemoryRepository<Entity>();
            var service = new EntityService(repository);

            service.CreateEntity(1, "Ejemplo");
            service.CreateEntity(2, "Otro");

            var all = service.GetAll();

            foreach (var e in all)
            {
                Console.WriteLine("ID: " + e.Id + ", Name: " + e.Name);
            }

            Console.ReadLine();
        }
    }
}
