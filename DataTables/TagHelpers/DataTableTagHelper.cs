using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using DataTables.Extensions;
using DataTables.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Newtonsoft.Json.Serialization;

namespace DataTables.TagHelpers
{
    [HtmlTargetElement(TAG_NAME)]
    public class DataTableTagHelper : TagHelper
    {
        internal const string TAG_NAME = "data-table";
        internal const string ATTR_NAME_DTO = "bind-dto";
        internal const string ATTR_NAME_OPTIONS = "options";
        internal const string ATTR_NAME_ID = "id";
        internal const string ATTR_NAME_CLASS = "class";
        
        private static readonly string DATA_TABLE_SCRIPT_TEMPLATE =
            "<script type='text/javascript'>" + Environment.NewLine +
            "  $(document).ready(function () {{" + Environment.NewLine +
            "    $('#{0}').DataTable(" + Environment.NewLine +
            "{1}" + Environment.NewLine +
            "    )}});" + Environment.NewLine +
            "</script>";

        [HtmlAttributeName(ATTR_NAME_DTO)]
        public Type DtoType { get; set; }

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


            var dataTableContext = new DataTableContext();
            context.Items[typeof(DataTableContext)] = dataTableContext;

            dataTableContext.DtoType = DtoType;

            await output.GetChildContentAsync();

            if (DtoType != null)
            {
                var columns = from property in DtoType.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase)
                              where !dataTableContext.ExcludeProperties.Contains(property)
                              select new DataTableOptionsColumn
                              {
                                  Title = property.GetDisplayName(),
                                  Data = property.GetNameCamelCase()
                              };

                Options = Options ?? new DataTableOptions();
                Options.Columns = columns.ToArray();
            }

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
