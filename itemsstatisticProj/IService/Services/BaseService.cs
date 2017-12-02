using IService.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Data.Interfaces;
using AutoMapper;

namespace IService.Services
{
    public class BaseService<D, T> : IBaseService<D>
    {
        protected IBaseRepository<T> _repository;
        public BaseService(IBaseRepository<T> repository)
        {
            _repository = repository;
        }
        public int Add(D itemDto)
        {
            var item = Mapper.Map<T>(itemDto);
            int id = _repository.Add(item);
            return id;
        }

        public List<D> GetAll()
        {
            var items = _repository.GetAll();
            return Mapper.Map<List<D>>(items);
        }

        public List<D> GetAll(int page, int amount)
        {
            var items = _repository.GetAll(page, amount);
            return Mapper.Map<List<D>>(items);
        }

        public D GetById(int id)
        {
            var item = _repository.GetById(id);
            return Mapper.Map<D>(item);
        }

        public int GetAmount()
        {
            return _repository.GetAmount();
        }

        public void Remove(int id)
        {
            _repository.Remove(id);
        }

        public void Update(D item)
        {
            _repository.Update(Mapper.Map<T>(item));
        }
    }
}
