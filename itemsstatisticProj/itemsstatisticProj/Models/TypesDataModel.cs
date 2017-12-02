using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class TypesDataModel
    {
        public List<Core.TypeDTO> Types { get; set; }
        public PaginationModel Pager { get; set; }
    }
}