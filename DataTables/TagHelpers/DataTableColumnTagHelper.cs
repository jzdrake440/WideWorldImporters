using DataTables.Models;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataTables.TagHelpers
{
    [HtmlTargetElement(TAG_NAME)]
    public class DataTableColumnTagHelper : TagHelper
    {
        public const string TAG_NAME = "column";
        public const string ATTR_NAME_COLUMN = "def";

        [HtmlAttributeName(ATTR_NAME_COLUMN)]
        public DataTableOptionsColumn Column { get; set; }
        
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var columnGroupContext = (DataTableColumnGroupContext)context.Items[typeof(DataTableColumnGroupContext)];
            columnGroupContext.Columns.Add(Column);
            output.SuppressOutput();
        }
    }
}
