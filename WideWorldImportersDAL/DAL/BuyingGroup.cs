using System;
using System.Collections.Generic;

namespace WideWorldImporters.DAL
{
    public partial class BuyingGroup
    {
        public BuyingGroup()
        {
            Customers = new HashSet<Customer>();
            SpecialDeals = new HashSet<SpecialDeal>();
        }

        public int BuyingGroupId { get; set; }
        public string BuyingGroupName { get; set; }
        public int LastEditedBy { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }

        public Person LastEditedByNavigation { get; set; }
        public ICollection<Customer> Customers { get; set; }
        public ICollection<SpecialDeal> SpecialDeals { get; set; }
    }
}
