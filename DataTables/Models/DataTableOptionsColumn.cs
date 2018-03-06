using DataTables.Expressions;
using DataTables.Json;
using Newtonsoft.Json;
using System;
using System.Linq.Expressions;

namespace DataTables.Models
{
    public class DataTableOptionsColumn
    {
        public string CellType { get; set; }
        public string ClassName { get; set; }
        public string ContentPadding { get; set; }
        public string CreatedCell { get; set; } //js function
        public string Data { get; set; } //TODO support objects https://datatables.net/reference/option/columns.data#Types
        public string DefaultContent { get; set; }
        public string Name { get; set; }
        public bool? Orderable { get; set; }
        public int[] OrderData { get; set; }
        public string OrderDataType { get; set; } //TODO enum
        public string[] OrderSequence { get; set; }


        [JsonConverter(typeof(FunctionSerializer))]
        public string Render { get; set; }


        public bool? Searchable { get; set; }
        public string Title { get; set; }
        public string Type { get; set; } //TODO enum
        public bool? Visible { get; set; }
        public string Width { get; set; }

        public DataTableOptionsSearch Search { get; set; } //used in server side requests
        public bool ShouldSerializeSearch()
        {
            return false;
        }
    }

    public class DataTableOptionsColumn<TModel, TColumn> : DataTableOptionsColumn
    {

        /* Render takes parameters (data, type, row, meta)
         * data is defined by the Data property
         * type is of "filter, display, type, sort, undefined or a custom value"
         * row is of the data source, which would be the Model data type
         * meta is an object and isn't currently supported by this C# implementation
         * https://datatables.net/reference/option/columns.render#Types
         */
        [JsonIgnore]
        public Expression<Func<TColumn, string, TModel, object, string>> RenderFunction
        {
            set
            {
                var visitor = new JavascriptExpressionVisitor();
                Render = visitor.ConvertToJavascript(value);
            }
        }
    }
}
 