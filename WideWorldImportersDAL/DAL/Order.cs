using System;
using System.Collections.Generic;

namespace WideWorldImporters.DAL
{
    public partial class Order
    {
        public Order()
        {
            InverseBackorderOrder = new HashSet<Order>();
            Invoices = new HashSet<Invoice>();
            OrderLines = new HashSet<OrderLine>();
        }

        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int SalespersonPersonId { get; set; }
        public int? PickedByPersonId { get; set; }
        public int ContactPersonId { get; set; }
        public int? BackorderOrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ExpectedDeliveryDate { get; set; }
        public string CustomerPurchaseOrderNumber { get; set; }
        public bool IsUndersupplyBackordered { get; set; }
        public string Comments { get; set; }
        public string DeliveryInstructions { get; set; }
        public string InternalComments { get; set; }
        public DateTime? PickingCompletedWhen { get; set; }
        public int LastEditedBy { get; set; }
        public DateTime LastEditedWhen { get; set; }

        public Order BackorderOrder { get; set; }
        public Person ContactPerson { get; set; }
        public Customer Customer { get; set; }
        public Person LastEditedByNavigation { get; set; }
        public Person PickedByPerson { get; set; }
        public Person SalespersonPerson { get; set; }
        public ICollection<Order> InverseBackorderOrder { get; set; }
        public ICollection<Invoice> Invoices { get; set; }
        public ICollection<OrderLine> OrderLines { get; set; }
    }
}
