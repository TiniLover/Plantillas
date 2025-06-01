
using Domain1;

namespace BLL
{
    public class EntityManager
    {
        public bool IsValid(Revista entity)
        {
            return entity != null && !string.IsNullOrWhiteSpace(entity.notificacion);
        }
    }
}
