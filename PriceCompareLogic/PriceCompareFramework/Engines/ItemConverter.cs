using PriceCompareFramework.Handlers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PriceCompareFramework.Engines
{
    public class ItemConverter
    {
        private string storeid { set; get; }
        private string chainid { set; get; }
        private DatabaseT db;
        public ItemConverter(DatabaseT _db)
        {
            db = _db;
        }
        
        public void InsertData(string path)
        {
            var items = ProccessItem(path);
       
            foreach (var item in items)
            {
                db.Items.Add(item);
            }
        }

        private IEnumerable<Item> ProccessItem(string path)
        {
            var query = XDocument.Load(path);
            var itemsX = query.Descendants("Item");
            var details = query.Descendants("Root");
            storeid = details.First().Element("StoreId")?.Value;
            chainid = details.First().Element("ChainId")?.Value;
            return itemsX.Select(GetItem).ToList();
        }

        private Item GetItem(XElement item)
        {
            var price = item.Element("ItemPrice")?.Value;
            return new Item(
                    item.Element("ItemCode")?.Value,
                    item.Element("ItemName")?.Value,
                    item.Element("ManufacturerName")?.Value,
                    item.Element("Quantity")?.Value,
                    item.Element("UnitQty")?.Value,
                    item.Element("UnitOfMeasure")?.Value,
                    item.Element("bIsWeighted")?.Value,
                    double.Parse(price),
                    item.Element("UnitOfMeasurePrice")?.Value,
                    item.Element("ItemId")?.Value,
                    storeid,
                    chainid
                );
        }
    }
}