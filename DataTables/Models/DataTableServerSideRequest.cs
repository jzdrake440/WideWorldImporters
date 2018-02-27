namespace DataTables.Models
{
    /*
     * Model for requests sent by DataTables.
     * https://datatables.net/manual/server-side
     */
    public class DataTableServerSideRequest
    {
        public int Draw { get; set; }
        public int Start { get; set; }
        public int Length { get; set; }
        
        public DataTableOptionsOrder[] Order { get; set; }
        public DataTableOptionsColumn[] Columns { get; set; }
        public DataTableOptionsSearch Search { get; set; }
    }
}