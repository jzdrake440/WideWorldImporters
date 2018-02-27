using System;
using System.Collections.Generic;
using System.Text;

namespace DataTables.Models
{
    public class DataTableOptions
    {
        //Features
        public bool? AutoWidth { get; set; }
        public bool? DeferRender { get; set; }
        public bool? Info { get; set; }
        public bool? LengthChange { get; set; }
        public bool? Ordering { get; set; }
        public bool? Paging { get; set; }
        public bool? Processing { get; set; }
        public bool? ScrollX { get; set; }
        public bool? ScrollY { get; set; }
        public bool? Searching { get; set; }
        public bool? ServerSide { get; set; }
        public bool? StateSave { get; set; }

        //Data
        public DataTableOptionsAjax Ajax { get; set; }
        public object[] Data { get; set; }

        //TODO Callbacks

        //Options
        public bool? DeferLoading { get; set; }
        public bool? Destroy { get; set; }
        public bool? DisplayStart { get; set; }
        public string Dom { get; set; }
        public bool? LengthMenu { get; set; }
        public DataTableOptionsOrder[] Order { get; set; }
        public bool? OrderCellsTop { get; set; }
        public bool? OrderClasses { get; set; }
        public DataTableOptionsOrder OrderFixed { get; set; }
        public bool? OrderMulti { get; set; }
        public int? PageLength { get; set; }
        public string PagingType { get; set; }
        public bool? Renderer { get; set; }
        public bool? Retrieve { get; set; }
        public string RowId { get; set; }
        public bool? ScrollCollapse { get; set; }
        public DataTableOptionsSearch Search { get; set; }
        public bool? SearchCols { get; set; }
        public int? SearchDelay { get; set; }
        public int? StateDuration { get; set; }
        public bool? StripeClasses { get; set; }
        public int? TabIndex { get; set; }

        //Columns
        public string ColumnDefs { get; set; } //TODO class
        public DataTableOptionsColumn[] Columns { get; set; }

        //TODO Internationalization

    }
}
