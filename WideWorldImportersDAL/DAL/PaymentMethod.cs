using System;
using System.Collections.Generic;

namespace WideWorldImporters.DAL
{
    public partial class PaymentMethod
    {
        public PaymentMethod()
        {
            CustomerTransactions = new HashSet<CustomerTransaction>();
            SupplierTransactions = new HashSet<SupplierTransaction>();
        }

        public int PaymentMethodId { get; set; }
        public string PaymentMethodName { get; set; }
        public int LastEditedBy { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }

        public Person LastEditedByNavigation { get; set; }
        public ICollection<CustomerTransaction> CustomerTransactions { get; set; }
        public ICollection<SupplierTransaction> SupplierTransactions { get; set; }
    }
}
