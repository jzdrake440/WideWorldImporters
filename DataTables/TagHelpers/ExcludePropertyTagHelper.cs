using Microsoft.AspNetCore.Razor.TagHelpers;

namespace DataTables.TagHelpers
{
    [HtmlTargetElement(TAG_NAME, ParentTag = DataTableTagHelper.TAG_NAME)]
    public class ExcludePropertyTagHelper : TagHelper
    {
        internal const string TAG_NAME = "exclude-property";

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            DataTableContext dataTableContext = (DataTableContext)context.Items[typeof(DataTableContext)];
            var propertyInfo = dataTableContext.DtoType.GetProperty(output.Content.GetContent());
            dataTableContext.ExcludeProperties.Add(propertyInfo);
            output.SuppressOutput();
        }

    }
}
