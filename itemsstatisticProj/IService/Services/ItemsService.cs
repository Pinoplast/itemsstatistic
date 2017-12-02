using Core;
using Data.Entities;
using Data.Interfaces;
using IService.Interfaces;
using IService.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IService.Services
{
    public class ItemsService: BaseService<ItemDTO, Item>, IItemsService
    {
        public ItemsService(IItemsRepository repository):base(repository)
        {

        }
    }
}
