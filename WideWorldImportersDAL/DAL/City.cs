using System;
using System.Collections.Generic;

namespace WideWorldImporters.DAL
{
    public partial class City
    {
        public City()
        {
            CustomerDeliveryCities = new HashSet<Customer>();
            CustomerPostalCities = new HashSet<Customer>();
            SupplierDeliveryCities = new HashSet<Supplier>();
            SupplierPostalCities = new HashSet<Supplier>();
            SystemParameterDeliveryCities = new HashSet<SystemParameter>();
            SystemParameterPostalCities = new HashSet<SystemParameter>();
        }

        public int CityId { get; set; }
        public string CityName { get; set; }
        public int StateProvinceId { get; set; }
        public long? LatestRecordedPopulation { get; set; }
        public int LastEditedBy { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }

        public Person LastEditedByNavigation { get; set; }
        public StateProvince StateProvince { get; set; }
        public ICollection<Customer> CustomerDeliveryCities { get; set; }
        public ICollection<Customer> CustomerPostalCities { get; set; }
        public ICollection<Supplier> SupplierDeliveryCities { get; set; }
        public ICollection<Supplier> SupplierPostalCities { get; set; }
        public ICollection<SystemParameter> SystemParameterDeliveryCities { get; set; }
        public ICollection<SystemParameter> SystemParameterPostalCities { get; set; }
    }
}
