using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PriceCompareFramework.Engines;
using PriceCompareFramework.Handlers;

namespace PriceCompareFramework.Manager
{
    public class Controller
    {
        private static DatabaseT _db;
        private GetListsFromDatabase _getThings;

        public Controller()
        {
            if (_db == null)
            {
                _db = DatabaseT.CreateNewObjectOfDatabase();
            }
            _getThings =  new GetListsFromDatabase(_db);

        }

        public IEnumerable<Item> GetAllItemsList()
        {
            return _getThings.GetAllItemsList();
        }

        public IEnumerable<Store> GetAllStoresList()
        {
            return _getThings.GetAllStoresList();
        }

        public IEnumerable<Item> GetItemsWithoutDuplicates()
        {
            return _getThings.GetItemsWithoutDuplicates();
        }

        public double CalculateItemsPriceInOneStore(Store s , IEnumerable<Item> items)
        {
            return _getThings.CalculateItemsPriceInOneStore(s, items);
        }

        public double GetItemPrice(Item item)
        {
            return _getThings.GetItemPrice(item);
        }

        public Store GetItemStore(Item item)
        {
            return _getThings.GetItemStore(item);
        }

        public Store GetMinPricesStore(IDictionary<Store, IEnumerable<Item>> f)
        {
            return _getThings.GetMinPricesStore(f);
        }

        public Tuple<Store, double> CalculatePriceAndReturnPriceAndStore(Store s, IEnumerable<Item> items)
        {
            return _getThings.CalculatePriceAndReturnPriceAndStore(s,items);
        }

        public Item GetThisItemInThisStore(Store s, Item i)
        {
            return _getThings.GetThisItemInThisStore(s, i);
        }

        public double CalculateItemsPriceInOneStoreWithQuantity(Store s,
            Dictionary<Item, Tuple<string, decimal>> itemsAndQuantity)
        {
            return _getThings.CalculateItemsPriceInOneStoreWithQuantity(s, itemsAndQuantity);
        }

        public IEnumerable<Item> GetTheCheapest3ItemsInStore(Store s)
        {
            return _getThings.GetTheCheapest3ItemsInStore(s);
        }

        public IEnumerable<Item> GetTheMostExp3ItemsInStore(Store s)
        {
            return _getThings.GetTheMostExp3ItemsInStore(s);
        }

    }

}
