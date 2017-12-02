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
    public class TypesRepository : BaseRepository<Data.Entities.Type>, ITypesRepository
    {
        public TypesRepository(DatabaseContext context):base(context)
        {
        }

        public new IEnumerable<Data.Entities.Type> GetAll()
        {
            return _dbset
                .Include(x => x.Items)
                .ToList();
        }

        public new IEnumerable<Data.Entities.Type> GetAll(int page, int amount)
        {
            return _dbset
                .Include(x => x.Items)
                .OrderBy(x => x.Id)
                .Skip((page - 1) * amount)
                .Take(amount)
                .ToList();
        }

        public new Data.Entities.Type GetById(int id)
        {
            return _dbset
                .Include(x => x.Items)
                .FirstOrDefault(x => x.Id == id);
        }

        public int GetAmountByName(string name)
        {
            int amount = _dbset
                .Include(x => x.Items)
                .Where(x => x.Name == name)
                .Count();
            return amount;
        }
    }
}
