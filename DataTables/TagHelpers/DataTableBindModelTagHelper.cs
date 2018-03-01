using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Linq;
using DataTables.Models;
using DataTables.Extensions;

namespace DataTables.TagHelpers
{
    [HtmlTargetElement(TAG_NAME, ParentTag = DataTableTagHelper.TAG_NAME)]
    public class DataTableBindModelTagHelper : TagHelper
    {
        public const string TAG_NAME = "bind-model";
        public const string ATTR_NAME_TYPE = "type";
        public const string ATTR_NAME_EXCLUDE = "exclude";

        [HtmlAttributeName(ATTR_NAME_TYPE)]
        public Type ModelType { get; set; }

        [HtmlAttributeName(ATTR_NAME_EXCLUDE)]
        public String[] ExcludeProperties { get; set; } = { };

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var columns = from property in ModelType.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase)
                            where !ExcludeProperties.Contains(property.Name)
                            select new DataTableOptionsColumn
                            {
                                Title = property.GetDisplayName(),
                                Data = property.GetNameCamelCase()
                            };

            var dataTableContext = (DataTableContext)context.Items[typeof(DataTableContext)];
            var options = dataTableContext.Options;

            options.Columns = options.Columns.Union(columns).ToArray();
        }
    }
}
