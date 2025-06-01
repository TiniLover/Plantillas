using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class InMemoryRepository<T> : IRepository<T> where T : class
    {
        private List<T> _items = new List<T>();

        public void Add(T item)
        {
            _items.Add(item);
        }

        public void Remove(T item)
        {
            _items.Remove(item);
        }

        public T GetById(int id)
        {
            var prop = typeof(T).GetProperty("Id");
            if (prop == null) return null;

            return _items.FirstOrDefault(i => (int)prop.GetValue(i) == id);
        }

        public List<T> GetAll()
        {
            return new List<T>(_items);
        }
    }
}


