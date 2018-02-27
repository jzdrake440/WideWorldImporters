using Newtonsoft.Json;

namespace DataTables.Models
{
    public class DataTableOptionsSearch
    {
        public bool? CaseInsensitive { get; set; }
        public bool? Regex { get; set; }
        public string Search { get; set; }
        public bool? Smart { get; set; }


        public string Value { get; set; }
        public bool ShouldSerializeValue()
        {
            return false;
        }
    }
}