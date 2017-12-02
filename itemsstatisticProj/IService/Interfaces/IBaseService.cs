using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IService.Interfaces
{
    public interface IBaseService<D>
    {
        List<D> GetAll();
        List<D> GetAll(int page, int amount);
        int Add(D item);
        int GetAmount();
        void Remove(int id);
        D GetById(int id);
        void Update(D item);
    }
}
