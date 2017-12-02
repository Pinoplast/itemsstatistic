using Core;
using Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Helpers;
using System.Web.Http;
using System.Web.Script.Serialization;
using IService.Interfaces;

namespace Web.Controllers
{
    public class TypesController : ApiController
    {
        private ITypesService _typesService;
        private IItemsService _itemsService;

        public TypesController(ITypesService typesService, IItemsService itemsService)
        {
            _itemsService = itemsService;
            _typesService = typesService;
        }
        // GET api/values
        public string Get()
        {
            var jsonSerializer = new JavaScriptSerializer();
            var data = new { first="value 1", second = "value 2" };
            return jsonSerializer.Serialize(data);
        }

        // GET api/values/5
        public string Get(int page, int amount)
        {
            var jsonSerialiser = new JavaScriptSerializer();

            int defaultPage = 1;
            int defaultAmount = 3;

            TypesDataModel model = new TypesDataModel();
            try
            {
                var types = _typesService.GetAll(page, amount);
                var total = _typesService.GetAmount();

                var pager = new PaginationModel()
                {
                    AmountItems = types.Count,
                    CurrentPage = total / ((types.Count == 0) ? 1 : types.Count),
                    TotalAmount = total
                };

                model.Types = types;
                model.Pager = pager;   
            }
            catch(Exception e)
            {
                var types = _typesService.GetAll(defaultPage, defaultAmount);
                var total = _typesService.GetAmount();

                var pager = new PaginationModel()
                {
                    AmountItems = types.Count,
                    CurrentPage = total / ((types.Count == 0) ? 1 : types.Count),
                    TotalAmount = total
                };

                model.Types = types;
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
