using System;
using System.Collections.Generic;
using System.Text;

namespace DataTables.Models
{
    //https://datatables.net/reference/option/ajax
    public class DataTableOptionsAjax : JQueryAjax
    {
        public string DataSrc { get; set; }
        public string Data { get; set; }
    }
}
