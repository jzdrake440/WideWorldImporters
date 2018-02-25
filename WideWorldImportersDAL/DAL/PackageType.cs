using System;
using System.Collections.Generic;

namespace WideWorldImporters.DAL
{
    public partial class PackageType
    {
        public PackageType()
        {
            InvoiceLines = new HashSet<InvoiceLine>();
            OrderLines = new HashSet<OrderLine>();
            PurchaseOrderLines = new HashSet<PurchaseOrderLine>();
            StockItemOuterPackages = new HashSet<StockItem>();
            StockItemUnitPackages = new HashSet<StockItem>();
        }

        public int PackageTypeId { get; set; }
        public string PackageTypeName { get; set; }
        public int LastEditedBy { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }

        public Person LastEditedByNavigation { get; set; }
        public ICollection<InvoiceLine> InvoiceLines { get; set; }
        public ICollection<OrderLine> OrderLines { get; set; }
        public ICollection<PurchaseOrderLine> PurchaseOrderLines { get; set; }
        public ICollection<StockItem> StockItemOuterPackages { get; set; }
        public ICollection<StockItem> StockItemUnitPackages { get; set; }
    }
}
