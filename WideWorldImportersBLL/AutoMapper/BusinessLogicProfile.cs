using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using WideWorldImporters.BLL.Models;
using WideWorldImporters.DAL;

namespace WideWorldImporters.AutoMapper
{
    public class BusinessLogicProfile : Profile
    {
        public BusinessLogicProfile()
        {
            CreateMap<BuyingGroup, BuyingGroupBl>();
            CreateMap<City, CityBl>();
            CreateMap<Color, ColorBl>();
            CreateMap<Country, CountryBl>();
            CreateMap<Customer, CustomerBl>();
            CreateMap<CustomerCategory, CustomerCategoryBl>();
            CreateMap<CustomerTransaction, CustomerTransactionBl>();
            CreateMap<DeliveryMethod, DeliveryMethodBl>();
            CreateMap<Invoice, InvoiceBl>();
            CreateMap<InvoiceLine, InvoiceLineBl>();
            CreateMap<Order, OrderBl>();
            CreateMap<OrderLine, OrderLineBl>();
            CreateMap<PackageType, PackageTypeBl>();
            CreateMap<PaymentMethod, PaymentMethodBl>();
            CreateMap<Person, PersonBl>();
            CreateMap<PurchaseOrder, PurchaseOrderBl>();
            CreateMap<PurchaseOrderLine, PurchaseOrderLineBl>();
            CreateMap<SpecialDeal, SpecialDealBl>();
            CreateMap<StateProvince, StateProvinceBl>();
            CreateMap<StockGroup, StockGroupBl>();
            CreateMap<StockItem, StockItemBl>();
            CreateMap<StockItemHolding, StockItemHoldingBl>();
            CreateMap<StockItemStockGroup, StockItemStockGroupBl>();
            CreateMap<StockItemTransaction, StockItemTransactionBl>();
            CreateMap<Supplier, SupplierBl>();
            CreateMap<SupplierCategory, SupplierCategoryBl>();
            CreateMap<SupplierTransaction, SupplierTransactionBl>();
            CreateMap<SystemParameter, SystemParameterBl>();
            CreateMap<TransactionType, TransactionTypeBl>();
        }
    }
}
