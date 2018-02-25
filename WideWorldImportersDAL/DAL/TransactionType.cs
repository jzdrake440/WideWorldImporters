using System;
using System.Collections.Generic;

namespace WideWorldImporters.DAL
{
    public partial class TransactionType
    {
        public TransactionType()
        {
            CustomerTransactions = new HashSet<CustomerTransaction>();
            StockItemTransactions = new HashSet<StockItemTransaction>();
            SupplierTransactions = new HashSet<SupplierTransaction>();
        }

        public int TransactionTypeId { get; set; }
        public string TransactionTypeName { get; set; }
        public int LastEditedBy { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }

        public Person LastEditedByNavigation { get; set; }
        public ICollection<CustomerTransaction> CustomerTransactions { get; set; }
        public ICollection<StockItemTransaction> StockItemTransactions { get; set; }
        public ICollection<SupplierTransaction> SupplierTransactions { get; set; }
    }
}
