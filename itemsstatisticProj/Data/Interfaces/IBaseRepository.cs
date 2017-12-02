using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IBaseRepository<T>
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAll(int page, int amount);
        int GetAmount();
        T GetById(int id);
        int Add(T item);
        void Update(T item);
        void Remove(int id);
        
    }
}
