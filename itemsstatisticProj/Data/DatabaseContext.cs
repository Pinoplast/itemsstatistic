using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;
namespace Data
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext():base("DefaultConnection")
        {
            
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Entities.Type> Types { get; set; }
    }
}
