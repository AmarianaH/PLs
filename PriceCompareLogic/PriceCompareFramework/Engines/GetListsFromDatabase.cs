using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PriceCompareFramework.Handlers;

namespace PriceCompareFramework.Engines
{
    /*Classes should not be named as operations - that is for methods
    It would be more fitting to call this class "DataProvider"
    Anyway- way to go on encapsulating data access from business logic!
    */
    internal class GetListsFromDatabase
    {
        private readonly DatabaseT _db;
        internal GetListsFromDatabase(DatabaseT db)
        {
            _db = db;
        }

        internal IEnumerable<Item> GetAllItemsList()
        {
            return _db.Items.Local.ToList();
        }

        internal IEnumerable<Store> GetAllStoresList()
        {
            return _db.Stores.Local.ToList();
        }

        internal IEnumerable<Item> GetItemsWithoutDuplicates()
        {
            var items = new HashSet<Item>();
            var codes = new HashSet<string>();
            foreach (var item in GetAllItemsList())
                if (!codes.Contains(item.ItemCode))
                {
                    codes.Add(item.ItemCode);
                    items.Add(item);
                }
            return items;

        }

        internal double CalculateItemsPriceInOneStore(Store s, IEnumerable<Item> items)
        {
            double sum = 0;
            foreach (var item in items)
            {
                var i = GetThisItemInThisStore(s, item);
                sum += GetItemPrice(i);
            }
            return sum;
        }



        internal double CalculateItemsPriceInOneStoreWithQuantity(Store s, Dictionary<Item, Tuple<string, decimal>> itemsAndQuantity )
        {
            double sum = 0;
            foreach (var item in itemsAndQuantity.Keys)
            {
                var i = GetThisItemInThisStore(s, item);
                Tuple<string,decimal> q;
                itemsAndQuantity.TryGetValue(item, out q);
                var quan  = Convert.ToDouble(q.Item2);
                sum += (GetItemPrice(i) * quan);
            }
            return sum;
        }

        internal double GetItemPrice(Item item)
        {
            return item?.ItemPrice ?? 0;
        }

        internal Store GetItemStore(Item item)
        {
            return GetAllStoresList().FirstOrDefault(store =>
                        store.ChainId.Equals(item.ChainId) && store.StoreId.Equals(item.StoreId)
            );
        }

        //This does not seem like the place for this method, considering the class' name
        //Consider: https://en.wikipedia.org/wiki/Single_responsibility_principle
        internal Store GetMinPricesStore(IDictionary<Store, IEnumerable<Item>> f )
        {
            double min = double.MaxValue - 100;
            Store minStore = null; 
            foreach (var store in f.Keys)
            {
                IEnumerable<Item> items;
                f.TryGetValue(store, out items);
                var priceAndStore = CalculatePriceAndReturnPriceAndStore(store, items);
                if (priceAndStore.Item2 < min)
                {
                    min = priceAndStore.Item2;
                    minStore = priceAndStore.Item1;
                }
            }
            return minStore;
        }

        //This does not seem like the place for this method, considering the class' name
        //Consider: https://en.wikipedia.org/wiki/Single_responsibility_principle
        internal Tuple<Store, double> CalculatePriceAndReturnPriceAndStore(Store s , IEnumerable<Item> items )
        {
            var price = CalculateItemsPriceInOneStore(s,items);
            return new Tuple< Store,double>(s,price);
        }

        //This does not seem like the place for this method, considering the class' name
        //Consider: https://en.wikipedia.org/wiki/Single_responsibility_principle
        internal Item GetThisItemInThisStore(Store s , Item i )
        {
            return GetAllItemsList().Where(item => item.ChainId == s.ChainId && item.StoreId == s.StoreId)
                .FirstOrDefault(item => item.ItemCode == i.ItemCode);
        }

        //This does not seem like the place for this method, considering the class' name
        //Consider: https://en.wikipedia.org/wiki/Single_responsibility_principle
        internal IEnumerable<Item> GetTheCheapest3ItemsInStore(Store s)
        {
            var cheapest = new List<Item>();
            for (int i = 0; i < 3; i++)
            {
                Item it = null;
                double MinValue = double.MaxValue-1;
                foreach (var item in GetAllItemsList())
                {
                    if (item.ChainId.Equals(s.ChainId) 
                        && item.StoreId.Equals(s.StoreId) 
                        && item.ItemPrice<MinValue && !cheapest.Contains(item))
                    {
                        MinValue = item.ItemPrice;
                        it = item;
                    }
                }
                cheapest.Add(it);
            }
            return cheapest;
        }

        //This does not seem like the place for this method, considering the class' name
        //Consider: https://en.wikipedia.org/wiki/Single_responsibility_principle
        internal IEnumerable<Item> GetTheMostExp3ItemsInStore(Store s)
        {
            var exp = new List<Item>();
            for (int i = 0; i < 3; i++)
            {
                Item it = null;
                double MaxValue = double.MinValue + 1;
                foreach (var item in GetAllItemsList())
                {
                    if (item.ChainId.Equals(s.ChainId)
                        && item.StoreId.Equals(s.StoreId)
                        && item.ItemPrice > MaxValue && !exp.Contains(item))
                    {
                        MaxValue = item.ItemPrice;
                        it = item;
                    }
                }
                exp.Add(it);
            }
            return exp;
        }
    }
}