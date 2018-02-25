using System;
using System.Collections.Generic;

namespace WideWorldImporters.DAL
{
    public partial class SpecialDeal
    {
        public int SpecialDealId { get; set; }
        public int? StockItemId { get; set; }
        public int? CustomerId { get; set; }
        public int? BuyingGroupId { get; set; }
        public int? CustomerCategoryId { get; set; }
        public int? StockGroupId { get; set; }
        public string DealDescription { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? DiscountPercentage { get; set; }
        public decimal? UnitPrice { get; set; }
        public int LastEditedBy { get; set; }
        public DateTime LastEditedWhen { get; set; }

        public BuyingGroup BuyingGroup { get; set; }
        public Customer Customer { get; set; }
        public CustomerCategory CustomerCategory { get; set; }
        public Person LastEditedByNavigation { get; set; }
        public StockGroup StockGroup { get; set; }
        public StockItem StockItem { get; set; }
    }
}
