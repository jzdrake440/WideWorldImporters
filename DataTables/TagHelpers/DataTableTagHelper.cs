using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Threading.Tasks;
using DataTables.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Newtonsoft.Json.Serialization;
using DataTables.TagHelpers.Contexts;

namespace DataTables.TagHelpers
{
    [HtmlTargetElement(TAG_NAME)]
    public class DataTableTagHelper : TagHelper
    {
        internal const string TAG_NAME = "data-table";
        internal const string ATTR_NAME_OPTIONS = "options";
        internal const string ATTR_NAME_ID = "id";
        
        private static readonly string DATA_TABLE_SCRIPT_TEMPLATE =
            "<script type='text/javascript'>\n" +
            "  $(document).ready(function () {{\n" +
            "    $('#{0}').DataTable(\n" +
            "{1}\n" +
            "    )}});\n" +
            "</script>";

        [HtmlAttributeName(ATTR_NAME_OPTIONS)]
        public DataTableOptions Options { get; set; }

        [HtmlAttributeName(ATTR_NAME_ID)]
        public string Id { get; set; }

        [ViewContext]
        public ViewContext ViewContext { get; set; }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "table";
            output.Attributes.Add("id", Id); //need to pass "id" through

            Options.Columns = Options.Columns ?? new DataTableOptionsColumn[0];
            var dataTableContext = new DataTableContext
            {
                Options = Options,
            };
            context.Items[typeof(DataTableContext)] = dataTableContext;

            await output.GetChildContentAsync();

            var json = JsonConvert.SerializeObject(
                Options,
                new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    Formatting = Formatting.Indented,
                    ContractResolver = new CamelCasePropertyNamesContractResolver()
                });

            //Since the layout is executed after the view; init the BodyTagContext if none existent
            if (!ViewContext.ViewData.TryGetValue(nameof(BodyTagContext), out object bodyTagContext))
                bodyTagContext = ViewContext.ViewData[nameof(BodyTagContext)] = new BodyTagContext();

            ((BodyTagContext)bodyTagContext).Scripts.Add(String.Format(DATA_TABLE_SCRIPT_TEMPLATE, Id, json));
        }
    }
}
