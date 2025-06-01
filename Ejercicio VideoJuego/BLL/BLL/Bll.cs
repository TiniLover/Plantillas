
using Domain;
using System.Collections.Generic;

namespace BLL
{
   
    public class EntityManager
    {
        public bool IsValid(Entity entity)
        {
            return entity != null && !string.IsNullOrWhiteSpace(entity.jugador);
            
        }
    }
}
