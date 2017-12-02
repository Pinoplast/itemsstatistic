using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IService.Interfaces
{
    public interface ITypesService: IBaseService<TypeDTO>
    {
        int GetAmountByName(string name);
    }
}
