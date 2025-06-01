using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Managers;
using Dal;
using Entities;

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

        public bool CreateEntity(int id, string name)
        {
            var entity = new Entity();
            entity.Id = id;
            entity.Name = name;

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
