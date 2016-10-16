using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PriceCompareFramework.Handlers;
using System.Xml.Linq;
using PriceCompareFramework.Engines;
using PriceCompareFramework.Manager;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Dictionary<Store, IEnumerable<Item>>();
            var items = new List<Item>();
            Controller c = new Controller();
            var q = c.GetAllItemsList();
            var store = (c.GetAllStoresList()).ElementAt(0);
            var item1 = c.GetThisItemInThisStore(store, q.ElementAt(0));
            var item2 = c.GetThisItemInThisStore(store, q.ElementAt(1));
            var item3 = c.GetThisItemInThisStore(store, q.ElementAt(2));
            items.Add(item1);
            items.Add(item2);
            items.Add(item3);
            a.Add(store, items);
            var print = c.GetMinPricesStore(a);
            Console.WriteLine($"{item1.ItemPrice} : {item2.ItemPrice} : {item3.ItemPrice} :  "); // item's prices
            Console.WriteLine(print.StoreId); // sotre 
            Console.WriteLine(c.CalculateItemsPrice(items)); // sum 
            Console.ReadLine();
        }
    }
}

     
     
     
     
     
     
     