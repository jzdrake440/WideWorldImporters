﻿namespace DataTables.Models
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
        
        public DataTableOrder[] Order { get; set; }
        public DataTableColumn[] Columns { get; set; }
        public DataTableSearch Search { get; set; }

        public class DataTableColumn
        {
            public string Data { get; set; }
            public string Name { get; set; }
            public bool Searchable { get; set; }
            public bool Orderable { get; set; }
            public DataTableSearch Search { get; set; }
        }

        public class DataTableSearch
        {
            public string Value { get; set; }
            public bool Regex { get; set; }
        }

        public class DataTableOrder
        {
            public int Column { get; set; }
            public string Dir { get; set; }
        }
    }
}