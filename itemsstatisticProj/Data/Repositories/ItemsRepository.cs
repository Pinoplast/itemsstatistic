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
    public class ItemsRepository : BaseRepository<Item>, IItemsRepository
    {
        public ItemsRepository(DatabaseContext context):base(context)
        {
        }

        public new IEnumerable<Item> GetAll()
        {
            return _dbset
                .Include(x => x.Type)
                .ToList();
        }

        public new IEnumerable<Item> GetAll(int page, int amount)
        {
            return _dbset
                .Include(x => x.Type)
                .OrderBy(x => x.Id)
                .Skip(page * amount)
                .Take(amount)
                .ToList();
        }

        public new Item GetById(int id)
        {
            return _dbset
                .Include(x => x.Type)
                .FirstOrDefault(x => x.Id == id);
        }
    }
}
