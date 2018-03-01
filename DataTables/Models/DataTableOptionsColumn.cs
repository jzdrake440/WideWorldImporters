using DataTables.Json;
using Newtonsoft.Json;

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
        public string Render { get; set; } //TODO support objects

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
}