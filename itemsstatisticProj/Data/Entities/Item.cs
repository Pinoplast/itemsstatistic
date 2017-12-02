using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities
{
    public class Item : BaseEntity
    {
        public string Name { get; set; }
        public int TypeId { get; set; }
        [ForeignKey("TypeId")]
        public Type Type { get; set; }
    }
}
