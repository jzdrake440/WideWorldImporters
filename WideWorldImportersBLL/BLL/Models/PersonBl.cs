using System;
using System.Collections.Generic;
using System.Text;

namespace WideWorldImporters.BLL.Models
{
    public partial class PersonBl
    {
        public int PersonId { get; set; }
        public string FullName { get; set; }
        public string PreferredName { get; set; }
        public string SearchName { get; set; }
        public bool IsPermittedToLogon { get; set; }
        public string LogonName { get; set; }
        public bool IsExternalLogonProvider { get; set; }
        public byte[] HashedPassword { get; set; }
        public bool IsSystemUser { get; set; }
        public bool IsEmployee { get; set; }
        public bool IsSalesperson { get; set; }
        public string UserPreferences { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string EmailAddress { get; set; }
        public byte[] Photo { get; set; }
        public string CustomFields { get; set; }
        public string OtherLanguages { get; set; }
        public int LastEditedBy { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }

        public PersonBl LastEditedByNavigation { get; set; }
        public ICollection<BuyingGroupBl> BuyingGroups { get; set; }
        public ICollection<CityBl> Cities { get; set; }
        public ICollection<ColorBl> Colors { get; set; }
        public ICollection<CountryBl> Countries { get; set; }
        public ICollection<CustomerBl> CustomerAlternateContactPeople { get; set; }
        public ICollection<CustomerCategoryBl> CustomerCategories { get; set; }
        public ICollection<CustomerBl> CustomerLastEditedByNavigations { get; set; }
        public ICollection<CustomerBl> CustomerPrimaryContactPeople { get; set; }
        public ICollection<CustomerTransactionBl> CustomerTransactions { get; set; }
        public ICollection<DeliveryMethodBl> DeliveryMethods { get; set; }
        public ICollection<PersonBl> InverseLastEditedByNavigation { get; set; }
        public ICollection<InvoiceBl> InvoiceAccountsPeople { get; set; }
        public ICollection<InvoiceBl> InvoiceContactPeople { get; set; }
        public ICollection<InvoiceBl> InvoiceLastEditedByNavigations { get; set; }
        public ICollection<InvoiceLineBl> InvoiceLines { get; set; }
        public ICollection<InvoiceBl> InvoicePackedByPeople { get; set; }
        public ICollection<InvoiceBl> InvoiceSalespersonPeople { get; set; }
        public ICollection<OrderBl> OrderContactPeople { get; set; }
        public ICollection<OrderBl> OrderLastEditedByNavigations { get; set; }
        public ICollection<OrderLineBl> OrderLines { get; set; }
        public ICollection<OrderBl> OrderPickedByPeople { get; set; }
        public ICollection<OrderBl> OrderSalespersonPeople { get; set; }
        public ICollection<PackageTypeBl> PackageTypes { get; set; }
        public ICollection<PaymentMethodBl> PaymentMethods { get; set; }
        public ICollection<PurchaseOrderBl> PurchaseOrderContactPeople { get; set; }
        public ICollection<PurchaseOrderBl> PurchaseOrderLastEditedByNavigations { get; set; }
        public ICollection<PurchaseOrderLineBl> PurchaseOrderLines { get; set; }
        public ICollection<SpecialDealBl> SpecialDeals { get; set; }
        public ICollection<StateProvinceBl> StateProvinces { get; set; }
        public ICollection<StockGroupBl> StockGroups { get; set; }
        public ICollection<StockItemHoldingBl> StockItemHoldings { get; set; }
        public ICollection<StockItemStockGroupBl> StockItemStockGroups { get; set; }
        public ICollection<StockItemTransactionBl> StockItemTransactions { get; set; }
        public ICollection<StockItemBl> StockItems { get; set; }
        public ICollection<SupplierBl> SupplierAlternateContactPeople { get; set; }
        public ICollection<SupplierCategoryBl> SupplierCategories { get; set; }
        public ICollection<SupplierBl> SupplierLastEditedByNavigations { get; set; }
        public ICollection<SupplierBl> SupplierPrimaryContactPeople { get; set; }
        public ICollection<SupplierTransactionBl> SupplierTransactions { get; set; }
        public ICollection<SystemParameterBl> SystemParameters { get; set; }
        public ICollection<TransactionTypeBl> TransactionTypes { get; set; }
    }
}
