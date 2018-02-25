using System;
using System.Collections.Generic;

namespace WideWorldImporters.DAL
{
    public partial class PurchaseOrder
    {
        public PurchaseOrder()
        {
            PurchaseOrderLines = new HashSet<PurchaseOrderLine>();
            StockItemTransactions = new HashSet<StockItemTransaction>();
            SupplierTransactions = new HashSet<SupplierTransaction>();
        }

        public int PurchaseOrderId { get; set; }
        public int SupplierId { get; set; }
        public DateTime OrderDate { get; set; }
        public int DeliveryMethodId { get; set; }
        public int ContactPersonId { get; set; }
        public DateTime? ExpectedDeliveryDate { get; set; }
        public string SupplierReference { get; set; }
        public bool IsOrderFinalized { get; set; }
        public string Comments { get; set; }
        public string InternalComments { get; set; }
        public int LastEditedBy { get; set; }
        public DateTime LastEditedWhen { get; set; }

        public Person ContactPerson { get; set; }
        public DeliveryMethod DeliveryMethod { get; set; }
        public Person LastEditedByNavigation { get; set; }
        public Supplier Supplier { get; set; }
        public ICollection<PurchaseOrderLine> PurchaseOrderLines { get; set; }
        public ICollection<StockItemTransaction> StockItemTransactions { get; set; }
        public ICollection<SupplierTransaction> SupplierTransactions { get; set; }
    }
}
