using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PriceCompareFramework.Handlers
{
    public class DatabaseT : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<Store> Stores { get; set; }

        public static DatabaseT CreateNewObjectOfDatabase()
        {
            DatabaseT db =  new DatabaseT();
            var c = new ConvertToDatabase(db);
            return db;
        }
    }
}