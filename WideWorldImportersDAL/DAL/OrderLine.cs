﻿using System;
using System.Collections.Generic;

namespace WideWorldImporters.DAL
{
    public partial class OrderLine
    {
        public int OrderLineId { get; set; }
        public int OrderId { get; set; }
        public int StockItemId { get; set; }
        public string Description { get; set; }
        public int PackageTypeId { get; set; }
        public int Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal TaxRate { get; set; }
        public int PickedQuantity { get; set; }
        public DateTime? PickingCompletedWhen { get; set; }
        public int LastEditedBy { get; set; }
        public DateTime LastEditedWhen { get; set; }

        public Person LastEditedByNavigation { get; set; }
        public Order Order { get; set; }
        public PackageType PackageType { get; set; }
        public StockItem StockItem { get; set; }
    }
}
