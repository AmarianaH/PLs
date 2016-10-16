using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PriceCompareFramework.Handlers
{
    public class Item
    {
        public Item(
            string itemCode, string itemName, string manufacturerName,
            string quantity, string unitQty, string unitOfMeasure,
            string bIsWeighted, double itemPrice, string unitOfMeasurePrice, string itemId, string storeId, string chainId)
        {
            ItemCode = itemCode;
            ItemName = itemName;
            ManufacturerName = manufacturerName;
            Quantity = quantity;
            UnitQty = unitQty;
            UnitOfMeasure = unitOfMeasure;
            BIsWeighted = bIsWeighted;
            ItemPrice = itemPrice;
            UnitOfMeasurePrice = unitOfMeasurePrice;
            ItemId = itemId;

            StoreId = storeId;
            ChainId = chainId;
        }

        public int Id { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string ManufacturerName { get; set; }
        public string UnitQty { get; set; }
        public string Quantity { get; set; }
        public string UnitOfMeasure { get; set; }
        public string BIsWeighted { get; set; }
        public double ItemPrice { get; set; }
        public string UnitOfMeasurePrice { get; set; }
        public string ItemId { get; set; }
        //
        public string StoreId { set; get; }
        public string ChainId { set; get; }
    }
}