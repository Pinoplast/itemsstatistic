using Core;
using Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Helpers;
using System.Web.Http;
using System.Web.Script.Serialization;
using IService.Interfaces;

namespace Web.Controllers
{
    public class ItemsController : ApiController
    {
        private ITypesService _typesService;
        private IItemsService _itemsService;
        public ItemsController(ITypesService typesService, IItemsService itemsService)
        {
            _typesService = typesService;
            _itemsService = itemsService;
        }

        public string Get()
        {
            var jsonSerializer = new JavaScriptSerializer();
            var data = new { first = "value 1", second = "value 2" };
            return jsonSerializer.Serialize(data);
        }
        public string Get(int id)
        {
            var jsonSerializer = new JavaScriptSerializer();
            var item = _itemsService.GetById(id);

            return jsonSerializer.Serialize(item);
        }
        // GET api/values/5
        public string Get(int page, int amount)
        {
            var jsonSerialiser = new JavaScriptSerializer();

            int defaultPage = 1;
            int defaultAmount = 3;

            ItemsDataModel model = new ItemsDataModel();
            try
            {
                var items = _itemsService.GetAll(page, amount);
                var total = _itemsService.GetAmount();

                var pager = new PaginationModel()
                {
                    AmountItems = items.Count,
                    CurrentPage = total / ((items.Count == 0) ? 1 : items.Count),
                    TotalAmount = total
                };

                model.Items = items;
                model.Pager = pager;
            }
            catch (Exception e)
            {
                var items = _itemsService.GetAll(defaultPage, defaultAmount);
                var total = _itemsService.GetAmount();

                var pager = new PaginationModel()
                {
                    AmountItems = items.Count,
                    CurrentPage = total / ((items.Count == 0) ? 1 : items.Count),
                    TotalAmount = total
                };

                model.Items = items;
                model.Pager = pager;
            }

            var json = jsonSerialiser.Serialize(model);
            return json;
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
