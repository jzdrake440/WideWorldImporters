using System;
using System.Collections.Generic;

namespace WideWorldImporters.DAL
{
    public partial class StockItemStockGroup
    {
        public int StockItemStockGroupId { get; set; }
        public int StockItemId { get; set; }
        public int StockGroupId { get; set; }
        public int LastEditedBy { get; set; }
        public DateTime LastEditedWhen { get; set; }

        public Person LastEditedByNavigation { get; set; }
        public StockGroup StockGroup { get; set; }
        public StockItem StockItem { get; set; }
    }
}
