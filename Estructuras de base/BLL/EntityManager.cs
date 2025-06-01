
using System.Collections.Generic;
using Dal;
using Entities;

namespace BLL.Managers
{
    public class EntityManager
    {
        public bool IsValid(Entity entity)
        {
            return !string.IsNullOrWhiteSpace(entity.Name);
        }
    }
}

