using Domain;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public interface IRepository<T>
    {
        void Add(T item);
        void Remove(T item);
        T GetById(int id);
        List<T> GetAll();
    }
}
