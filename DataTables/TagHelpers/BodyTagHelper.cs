using DataTables.TagHelpers.Contexts;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Threading.Tasks;

namespace DataTables.TagHelpers
{
    [HtmlTargetElement(TAG_NAME)]
    public class BodyTagHelper : TagHelper
    {
        public const string TAG_NAME = "body";

        [ViewContext]
        public ViewContext ViewContext { get; set; }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            //Since the layout is executed after the view; init the BodyTagContext if none existent
            if (!ViewContext.ViewData.TryGetValue(nameof(BodyTagContext), out object bodyTagContext))
                bodyTagContext = ViewContext.ViewData[nameof(BodyTagContext)] = new BodyTagContext();

            await output.GetChildContentAsync();

            foreach (string script in ((BodyTagContext)bodyTagContext).Scripts)
            {
                output.PostElement.AppendHtml(Environment.NewLine);
                output.PostElement.AppendHtml(script);
            }
        }
    }
}
