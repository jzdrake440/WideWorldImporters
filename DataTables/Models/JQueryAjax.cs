using System;
using System.Collections.Generic;
using System.Text;

namespace DataTables.Models
{
    //TODO make more comprehensive based on jquery settings
    //http://api.jquery.com/jquery.ajax/
    public class JQueryAjax
    {
        public string Url { get; set; }
        public string Type { get; set; } //TODO make enum
    }
}
