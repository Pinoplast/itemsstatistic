using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class PaginationModel
    {
        public int CurrentPage { get; set; }
        public int AmountItems { get; set; }
        public int TotalAmount { get; set; }
    }
}