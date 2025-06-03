using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public interface IRepository<T>
    {
        void Add(T item);
        void Remove(T item);
        T GetById(int id);
        List<T> GetAll();
    }
}
