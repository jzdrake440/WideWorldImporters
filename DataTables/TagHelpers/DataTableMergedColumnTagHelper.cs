using DataTables.Models;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataTables.TagHelpers
{
    [HtmlTargetElement(TAG_NAME)]
    public class DataTableMergedColumnTagHelper : DataTableColumnTagHelper
    {
        internal new const string TAG_NAME = "merged-column";

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var columnGroupContext = (DataTableColumnGroupContext)context.Items[typeof(DataTableColumnGroupContext)];
            var mergedColumnContext = new DataTableColumnGroupContext();
            context.Items[typeof(DataTableColumnGroupContext)] = mergedColumnContext;

            await output.GetChildContentAsync();

            var newColumn = new DataTableOptionsColumn();
            newColumn.Searchable = false; //TODO add support
            newColumn.Orderable = false; //TODO add support

            StringBuilder renderFunction = new StringBuilder();
            renderFunction.AppendLine("function(data, type, row, meta) {");
            renderFunction.AppendLine("  var ret = '';");

            foreach(var column in mergedColumnContext.Columns)
            {
                renderFunction.AppendFormat(
                    "  ret += {0}(row{1}, type, row, meta);", 
                    column.Render ?? "function(data){return data;}",
                    column.Data?.Insert(0,".")
                ).AppendLine();
            }

            renderFunction.AppendLine("  return ret;");
            renderFunction.Append("}");

            newColumn.Render = renderFunction.ToString();
            
            columnGroupContext.Columns.Add(newColumn);
            output.SuppressOutput();
        }
    }
}
