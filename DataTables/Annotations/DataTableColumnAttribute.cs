using Javascript.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataTables.Annotations
{
    [AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
    public class DataTableColumnAttribute : Attribute
    {
        public object Render { get; set; }
    }
}
