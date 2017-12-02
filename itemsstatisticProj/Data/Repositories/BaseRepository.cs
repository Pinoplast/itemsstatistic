using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Data.Entity;
using Data.Entities;

namespace Data.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T>
        where T : BaseEntity
    {
        protected DatabaseContext _context;
        protected readonly IDbSet<T> _dbset;

        public BaseRepository(DatabaseContext context)
        {
            _context = context;
            _dbset = _context.Set<T>();
        }

        public int Add(T item)
        {
            int id = _dbset.Add(item).Id;
            _context.SaveChanges();
            return id;
        }

        public IEnumerable<T> GetAll()
        {
            return _dbset.ToList();
        }

        public IEnumerable<T> GetAll(int page, int amount)
        {
            return _dbset
                .OrderBy(x => x.Id)
                .Skip((page-1) * amount)
                .Take(amount)
                .ToList();
        }

        public T GetById(int id)
        {
            return _dbset.FirstOrDefault(x => x.Id == id);
        }

        public int GetAmount()
        {
            return _dbset.Count();
        }

        public void Remove(int id)
        {
            var item = _dbset.FirstOrDefault(x => x.Id == id);
            _dbset.Remove(item);
            _context.SaveChanges();
        }

        public void Update(T item)
        {
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
