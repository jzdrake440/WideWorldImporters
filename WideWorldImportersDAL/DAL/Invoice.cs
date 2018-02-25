using System;
using System.Collections.Generic;

namespace WideWorldImporters.DAL
{
    public partial class Invoice
    {
        public Invoice()
        {
            CustomerTransactions = new HashSet<CustomerTransaction>();
            InvoiceLines = new HashSet<InvoiceLine>();
            StockItemTransactions = new HashSet<StockItemTransaction>();
        }

        public int InvoiceId { get; set; }
        public int CustomerId { get; set; }
        public int BillToCustomerId { get; set; }
        public int? OrderId { get; set; }
        public int DeliveryMethodId { get; set; }
        public int ContactPersonId { get; set; }
        public int AccountsPersonId { get; set; }
        public int SalespersonPersonId { get; set; }
        public int PackedByPersonId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public string CustomerPurchaseOrderNumber { get; set; }
        public bool IsCreditNote { get; set; }
        public string CreditNoteReason { get; set; }
        public string Comments { get; set; }
        public string DeliveryInstructions { get; set; }
        public string InternalComments { get; set; }
        public int TotalDryItems { get; set; }
        public int TotalChillerItems { get; set; }
        public string DeliveryRun { get; set; }
        public string RunPosition { get; set; }
        public string ReturnedDeliveryData { get; set; }
        public DateTime? ConfirmedDeliveryTime { get; set; }
        public string ConfirmedReceivedBy { get; set; }
        public int LastEditedBy { get; set; }
        public DateTime LastEditedWhen { get; set; }

        public Person AccountsPerson { get; set; }
        public Customer BillToCustomer { get; set; }
        public Person ContactPerson { get; set; }
        public Customer Customer { get; set; }
        public DeliveryMethod DeliveryMethod { get; set; }
        public Person LastEditedByNavigation { get; set; }
        public Order Order { get; set; }
        public Person PackedByPerson { get; set; }
        public Person SalespersonPerson { get; set; }
        public ICollection<CustomerTransaction> CustomerTransactions { get; set; }
        public ICollection<InvoiceLine> InvoiceLines { get; set; }
        public ICollection<StockItemTransaction> StockItemTransactions { get; set; }
    }
}
