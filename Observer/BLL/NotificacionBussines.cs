using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Domain;

namespace BLL
{
    public class NotificacionBussines
    {
        private IRepository<Entity> repositorio;
        public bool IsValid(Entity entity)
        {
            return entity != null && !string.IsNullOrWhiteSpace(entity.Noticia);
        }
        public NotificacionBussines(IRepository<Entity> repositorio)
        {
            this.repositorio = repositorio;
        }

        public int FuncionCategoria(bool pesca, bool humor, bool deportes, int tipoCategoria, bool v)
        {
            var repo = new Dao<Entity>();
            tipoCategoria = repo.AgregarCategorias( pesca, humor, deportes, tipoCategoria);
            return tipoCategoria;
        }
        public string FuncionDeNotificacion(string noticia, bool pesca,bool humor, bool deportes)
        {
            string notificacion = "";
            var repo= new Dao<Entity>();
            notificacion = repo.RecibirNotificacion(noticia,Convert.ToString (pesca),Convert.ToString (humor),Convert.ToString (deportes));
            return notificacion;
        }
        public bool CrearEntidad(int id, string noticia)
        {
            var entity = new Entity();
            entity.Id = id;
            entity.Noticia = noticia;

            if (!IsValid(entity))
                return false;

            repositorio.Add(entity); 

            return true;
        }

    }
}
