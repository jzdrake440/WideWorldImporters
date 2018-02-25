using System;
using System.Collections.Generic;

namespace WideWorldImporters.DAL
{
    public partial class StockItem
    {
        public StockItem()
        {
            InvoiceLines = new HashSet<InvoiceLine>();
            OrderLines = new HashSet<OrderLine>();
            PurchaseOrderLines = new HashSet<PurchaseOrderLine>();
            SpecialDeals = new HashSet<SpecialDeal>();
            StockItemStockGroups = new HashSet<StockItemStockGroup>();
            StockItemTransactions = new HashSet<StockItemTransaction>();
        }

        public int StockItemId { get; set; }
        public string StockItemName { get; set; }
        public int SupplierId { get; set; }
        public int? ColorId { get; set; }
        public int UnitPackageId { get; set; }
        public int OuterPackageId { get; set; }
        public string Brand { get; set; }
        public string Size { get; set; }
        public int LeadTimeDays { get; set; }
        public int QuantityPerOuter { get; set; }
        public bool IsChillerStock { get; set; }
        public string Barcode { get; set; }
        public decimal TaxRate { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal? RecommendedRetailPrice { get; set; }
        public decimal TypicalWeightPerUnit { get; set; }
        public string MarketingComments { get; set; }
        public string InternalComments { get; set; }
        public byte[] Photo { get; set; }
        public string CustomFields { get; set; }
        public string Tags { get; set; }
        public string SearchDetails { get; set; }
        public int LastEditedBy { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }

        public Color Color { get; set; }
        public Person LastEditedByNavigation { get; set; }
        public PackageType OuterPackage { get; set; }
        public Supplier Supplier { get; set; }
        public PackageType UnitPackage { get; set; }
        public StockItemHolding StockItemHolding { get; set; }
        public ICollection<InvoiceLine> InvoiceLines { get; set; }
        public ICollection<OrderLine> OrderLines { get; set; }
        public ICollection<PurchaseOrderLine> PurchaseOrderLines { get; set; }
        public ICollection<SpecialDeal> SpecialDeals { get; set; }
        public ICollection<StockItemStockGroup> StockItemStockGroups { get; set; }
        public ICollection<StockItemTransaction> StockItemTransactions { get; set; }
    }
}
