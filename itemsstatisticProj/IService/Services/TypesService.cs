using Core;
using Data.Interfaces;
using Data.Repositories;
using IService.Interfaces;
using IService.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IService.Services
{
    public class TypesService: BaseService<TypeDTO, Data.Entities.Type>, ITypesService
    {
        protected new ITypesRepository _repository;
        public TypesService(ITypesRepository repository):base(repository)
        {
            _repository = repository;
        }

        public int GetAmountByName(string name)
        {
            return _repository.GetAmountByName(name);
        }
    }
}
