using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class ItemsDataModel
    {
        public List<ItemDTO> Items { get; set; }
        public PaginationModel Pager {get;set;}
    }
}