using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Dal
{
    public class Dao<T> : IRepository<T> where T : class
    {
        private List<T> _items = new List<T>();
        public void Add(T item)
        {
            _items.Add(item);
        }

        public List<T> GetAll()
        {
            return new List<T>(_items);
        }

        public T GetById(int id)
        {
            var prop = typeof(T).GetProperty("Id");
            if (prop == null) return null;

            return _items.FirstOrDefault(i => (int)prop.GetValue(i) == id);
        }

        public void Remove(T item)
        {
            _items.Remove(item);
        }
        public int AgregarCategorias(bool pesca, bool humor, bool deportes, int tipoCategoria)


        {
            if (deportes == true)
            {
                return tipoCategoria;
            }
            else if (humor == true)
            {
                return tipoCategoria;
            }
            else if (pesca == true)
            {
                return tipoCategoria;
            }
            return tipoCategoria;
        }


        public string RecibirNotificacion(string noticia, string pesca, string humor, string deportes)
        {
            string notificacion = "";
            if (noticia == pesca)
            {
                notificacion = "Hay una nueva noticia en la seccion pesca";
                
            }
            else if (noticia == humor)
            {
                notificacion = "Hay una nueva noticia en la seccion humor";
            }
            else if(noticia == deportes)
            {
                notificacion="Hay una nueva actualizacion en la seccion deportes";
            }
            return notificacion; 
        }
    }
}
