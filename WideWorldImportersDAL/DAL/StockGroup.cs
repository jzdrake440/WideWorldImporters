using System;
using System.Collections.Generic;

namespace WideWorldImporters.DAL
{
    public partial class StockGroup
    {
        public StockGroup()
        {
            SpecialDeals = new HashSet<SpecialDeal>();
            StockItemStockGroups = new HashSet<StockItemStockGroup>();
        }

        public int StockGroupId { get; set; }
        public string StockGroupName { get; set; }
        public int LastEditedBy { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }

        public Person LastEditedByNavigation { get; set; }
        public ICollection<SpecialDeal> SpecialDeals { get; set; }
        public ICollection<StockItemStockGroup> StockItemStockGroups { get; set; }
    }
}
