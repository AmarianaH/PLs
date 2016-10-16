using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCompareFramework.Handlers
{
    //Very good and flexible model
    public class Store
    {
        
        public Store(string chainId, string subChainId, string storeId , string storeName )
        {
            ChainId = chainId;
            SubChainId = subChainId;
            StoreId = storeId;
            StoreName = storeName;

            // 
            // Items = new HashSet<Item>();
        }

        public int Id { get; set; }
        public string ChainId { get; set; }
        public string SubChainId{ get; set; }
        public string StoreId { get; set; }
        public string StoreName { get; set; }

        // Navigation properties : 
        // public ICollection<Item> Items { get; set; }
    }
}
