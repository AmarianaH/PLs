using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using PriceCompareFramework.Handlers;

namespace PriceCompareFramework.Engines
{
    internal class StoreConverter
    {
        internal DatabaseT db;
        internal StoreConverter(DatabaseT _db)
        {
            db = _db;
        }

        internal void InsertData(string path)
        {
            var stores = ProccessStore(path);
            //TODO Ihave to Change That (9)
            //if (db.Stores.Count() < 9)
            //{
                foreach (var store in stores)
                {
                    db.Stores.Add(store);
                }
            //}
        }

        private IEnumerable<Store> ProccessStore(string path)
        {
            var query = XDocument.Load(path);
            var storesX = query.Descendants("Root");
            return storesX.Select(GetStore).ToList();
        }

        private Store GetStore(XElement store)
        {
            var y = new Store(
                chainId: store.Element("ChainId")?.Value,
                subChainId: store.Element("SubChainId")?.Value,
                storeId: store.Element("StoreId")?.Value,
                storeName : store.Element("StoreName")?.Value
            );
            return y;
        }
    }
}
