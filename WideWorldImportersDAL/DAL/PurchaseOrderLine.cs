using System;
using System.Collections.Generic;

namespace WideWorldImporters.DAL
{
    public partial class PurchaseOrderLine
    {
        public int PurchaseOrderLineId { get; set; }
        public int PurchaseOrderId { get; set; }
        public int StockItemId { get; set; }
        public int OrderedOuters { get; set; }
        public string Description { get; set; }
        public int ReceivedOuters { get; set; }
        public int PackageTypeId { get; set; }
        public decimal? ExpectedUnitPricePerOuter { get; set; }
        public DateTime? LastReceiptDate { get; set; }
        public bool IsOrderLineFinalized { get; set; }
        public int LastEditedBy { get; set; }
        public DateTime LastEditedWhen { get; set; }

        public Person LastEditedByNavigation { get; set; }
        public PackageType PackageType { get; set; }
        public PurchaseOrder PurchaseOrder { get; set; }
        public StockItem StockItem { get; set; }
    }
}
