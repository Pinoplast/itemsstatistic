using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Type:BaseEntity
    {
        public Type()
        {
            
        }

        public string Name { get; set; }
        
        public virtual ICollection<Item> Items { get; set; }
    }
}
