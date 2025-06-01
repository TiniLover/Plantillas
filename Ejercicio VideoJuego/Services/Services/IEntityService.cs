using Domain;
using System.Collections.Generic;


using BLL;
using DAL;


namespace Services
{
    public class EntityService
    {
        private IRepository<Entity> _repository;
        private EntityManager _manager;

        public EntityService(IRepository<Entity> repository)
        {
            _repository = repository;
            _manager = new EntityManager();
        }

        public bool CreateEntity(int id, string name, int salud)
        {
            var entity = new Entity();
            entity.velocidad = id;
            entity.jugador = name;
            entity.salud = salud;

            if (!_manager.IsValid(entity))
                return false;

            _repository.Add(entity);
            return true;
        }

        public List<Entity> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
