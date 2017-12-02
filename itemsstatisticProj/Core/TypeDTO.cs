using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class TypeDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public int AmountOfDependencies { get; set; }
        internal ICollection<ItemDTO> Items { get; set; }
    }
}
