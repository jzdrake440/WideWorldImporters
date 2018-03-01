using DataTables.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataTables.TagHelpers
{
    public class DataTableColumnGroupContext
    {
        public readonly HashSet<DataTableOptionsColumn> Columns = new HashSet<DataTableOptionsColumn>();
    }
}
