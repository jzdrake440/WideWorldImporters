using System;
using System.Collections.Generic;

namespace WideWorldImporters.DAL
{
    public partial class StockItemHolding
    {
        public int StockItemId { get; set; }
        public int QuantityOnHand { get; set; }
        public string BinLocation { get; set; }
        public int LastStocktakeQuantity { get; set; }
        public decimal LastCostPrice { get; set; }
        public int ReorderLevel { get; set; }
        public int TargetStockLevel { get; set; }
        public int LastEditedBy { get; set; }
        public DateTime LastEditedWhen { get; set; }

        public Person LastEditedByNavigation { get; set; }
        public StockItem StockItem { get; set; }
    }
}
