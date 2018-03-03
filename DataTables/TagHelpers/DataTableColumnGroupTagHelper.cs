using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using DataTables.TagHelpers.Contexts;

namespace DataTables.TagHelpers
{
    [HtmlTargetElement(TAG_NAME)]
    public class DataTableColumnGroupTagHelper : TagHelper
    {
        public const string TAG_NAME = "columns";

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var columnGroupContext = new DataTableColumnGroupContext();
            context.Items[typeof(DataTableColumnGroupContext)] = columnGroupContext;

            await output.GetChildContentAsync();

            var dataTableContext = (DataTableContext)context.Items[typeof(DataTableContext)];
            var options = dataTableContext.Options;

            options.Columns = options.Columns.Union(columnGroupContext.Columns).ToArray();
            
            output.SuppressOutput();
        }
    }
}
