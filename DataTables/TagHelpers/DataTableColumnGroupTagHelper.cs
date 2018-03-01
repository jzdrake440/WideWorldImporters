using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataTables.TagHelpers
{
    [HtmlTargetElement(TAG_NAME)]
    public class DataTableColumnGroupTagHelper : TagHelper
    {
        internal const string TAG_NAME = "columns";

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var columnGroupContext = new DataTableColumnGroupContext();
            context.Items[typeof(DataTableColumnGroupContext)] = columnGroupContext;

            await output.GetChildContentAsync();

            var dataTableContext = (DataTableContext)context.Items[typeof(DataTableContext)];

            dataTableContext.Columns.UnionWith(columnGroupContext.Columns);
            
            output.SuppressOutput();
        }
    }
}
