using BillingSoftware.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSoftware
{
    class ItemContex : DbContext
    {
        static ItemContex()
        {
            Database.SetInitializer<ItemContex>(new CreateDatabaseIfNotExists<ItemContex>());
            using (ItemContex db = new ItemContex())
                db.Database.Initialize(true);
        }

        public DbSet<Thing> Things { get; set; }
        public DbSet<BuySell> BuySells { get; set; }
    }

    class DbInitializer : CreateDatabaseIfNotExists<ItemContex>
    {
        protected override void Seed(ItemContex context)
        {
            
            base.Seed(context);
        }
    }
}
