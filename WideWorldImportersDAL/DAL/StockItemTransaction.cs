using System;
using System.Collections.Generic;

namespace WideWorldImporters.DAL
{
    public partial class StockItemTransaction
    {
        public int StockItemTransactionId { get; set; }
        public int StockItemId { get; set; }
        public int TransactionTypeId { get; set; }
        public int? CustomerId { get; set; }
        public int? InvoiceId { get; set; }
        public int? SupplierId { get; set; }
        public int? PurchaseOrderId { get; set; }
        public DateTime TransactionOccurredWhen { get; set; }
        public decimal Quantity { get; set; }
        public int LastEditedBy { get; set; }
        public DateTime LastEditedWhen { get; set; }

        public Customer Customer { get; set; }
        public Invoice Invoice { get; set; }
        public Person LastEditedByNavigation { get; set; }
        public PurchaseOrder PurchaseOrder { get; set; }
        public StockItem StockItem { get; set; }
        public Supplier Supplier { get; set; }
        public TransactionType TransactionType { get; set; }
    }
}
