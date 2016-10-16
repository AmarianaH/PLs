using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PriceCompareFramework.Engines;
using PriceCompareFramework.Constants;

namespace PriceCompareFramework.Handlers
{
    /// <summary>
    /// this method delete all the data in the tables
    /// then adds a data from xml Files.
    /// into 2 tables ( Items and Stores ) 
    /// </summary>
    
        //This is a class - not a method- consider naming it approperiately
    internal class ConvertToDatabase
    {
        private readonly ItemConverter _itemConverter;
        private readonly StoreConverter _storeConverter;
        private readonly DatabaseT _db;

        internal ConvertToDatabase(DatabaseT db)
        {
            _db = db;
            Seed();
            _itemConverter = new ItemConverter(_db);
            _storeConverter = new StoreConverter(_db);
            ConvertItemsAndStoresToDatabase();
        }

        internal void ConvertItemsAndStoresToDatabase()
        {
            //Items
            _itemConverter.InsertData(XmlFilesPaths.OsherAd1);
            _itemConverter.InsertData(XmlFilesPaths.OsherAd2);
            _itemConverter.InsertData(XmlFilesPaths.OsherAd3);

            _itemConverter.InsertData(XmlFilesPaths.DorAlon1);
            _itemConverter.InsertData(XmlFilesPaths.DorAlon2);
            _itemConverter.InsertData(XmlFilesPaths.DorAlon3);

            _itemConverter.InsertData(XmlFilesPaths.TivTaam1);
            _itemConverter.InsertData(XmlFilesPaths.TivTaam2);
            _itemConverter.InsertData(XmlFilesPaths.TivTaam3);

            // Store
            _storeConverter.InsertData(XmlFilesPaths.OsherAd1);
            _storeConverter.InsertData(XmlFilesPaths.OsherAd2);
            _storeConverter.InsertData(XmlFilesPaths.OsherAd3);

            _storeConverter.InsertData(XmlFilesPaths.DorAlon1);
            _storeConverter.InsertData(XmlFilesPaths.DorAlon2);
            _storeConverter.InsertData(XmlFilesPaths.DorAlon3);

            _storeConverter.InsertData(XmlFilesPaths.TivTaam1);
            _storeConverter.InsertData(XmlFilesPaths.TivTaam2);
            _storeConverter.InsertData(XmlFilesPaths.TivTaam3);


            _db.SaveChanges();
        }

        public void Seed()
        {
            if (_db.Database == null) return;

            var listOfTables = new List<string> {"Items", "Stores"};

            foreach (var tableName in listOfTables)
                _db.Database.ExecuteSqlCommand("TRUNCATE TABLE [" + tableName + "]");

            _db.SaveChanges();
        }
    }
}