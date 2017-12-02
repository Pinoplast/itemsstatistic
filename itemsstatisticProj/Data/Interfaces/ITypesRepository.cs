using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface ITypesRepository:IBaseRepository<Data.Entities.Type>
    {
        int GetAmountByName(string name);
    }
}
