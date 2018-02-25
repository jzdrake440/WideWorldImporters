using System;
using System.Collections.Generic;

namespace WideWorldImporters.DAL
{
    public partial class Color
    {
        public Color()
        {
            StockItems = new HashSet<StockItem>();
        }

        public int ColorId { get; set; }
        public string ColorName { get; set; }
        public int LastEditedBy { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }

        public Person LastEditedByNavigation { get; set; }
        public ICollection<StockItem> StockItems { get; set; }
    }
}
