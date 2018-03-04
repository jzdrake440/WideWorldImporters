using DataTables.Annotations;
using Javascript.Builder;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WideWorldImporters.Extensions;

namespace WideWorldImporters.Model.Dto
{
    public class PersonSearchDto
    {
        [Display(Name = "Person ID")]
        public int PersonId { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Display(Name = "Preferred Name")]
        public string PreferredName { get; set; }

        [Display(Name = "IsPermittedToLogon")]
        public bool IsPermittedToLogon { get; set; }

        [Display(Name = "Logon Name")]
        public string LogonName { get; set; }

        [Display(Name = "IsExternalLogonProvider")]
        public bool IsExternalLogonProvider { get; set; }

        [Display(Name = "IsSystemUser")]
        public bool IsSystemUser { get; set; }

        [Display(Name = "IsEmployee")]
        public bool IsEmployee { get; set; }

        [Display(Name = "IsSalesperson")]
        public bool IsSalesperson { get; set; }

        [Display(Name = "User Preferences")]
        public string UserPreferences { get; set; }

        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Fax Number")]
        public string FaxNumber { get; set; }

        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Display(Name = "Custom Fields")]
        public string CustomFields { get; set; }

        [Display(Name = "Other Languages")]
        public string OtherLanguages { get; set; }

        [Display(Name = "Last Edited By")]
        public int LastEditedBy { get; set; }

        [Display(Name = "Valid From")]
        public DateTime ValidFrom { get; set; }

        [Display(Name = "Valid To")]
        public DateTime ValidTo { get; set; }

        [DataTableColumn(Render = nameof(GetMergedColumnFunction))]
        public string MergedColumn { get; set; }

        private JavascriptFunction GetMergedColumnFunction()
        {
            var RenderTemplate =
                "<span data-toggle=\"tooltip\" title=\"{0}\" class=\"pl-1\">" +
                "<i class=\"{1}\" style=\"color:{2}\"></i>" +
                "</span>`; }}";

            var data = JavascriptVariableExpression.CreateVariable("data");
            var type = JavascriptVariableExpression.CreateVariable("type");
            var row = JavascriptVariableExpression.CreateVariable("row");
            var meta = JavascriptVariableExpression.CreateVariable("meta");

            var ret = JavascriptVariableExpression.CreateVariable("ret");

            return JavascriptFunction.CreateFunction(
                JavascriptStatementBlock.CreateBlock(
                    JavascriptVariableDeclaration.CreateDeclaration(
                        ret,
                        JavascriptConstantExpression<string>.CreateConstant("")),
                    JavascriptBinaryExpression.CreateExpression(
                        JavascriptBinaryOperators.ADD_EQ,
                        ret,
                        JavascriptInvokeExpression.CreateInvoke(
                            GetBoolIconColumnJsFunction1(
                                nameof(IsPermittedToLogon).ToCamelCase(),
                                String.Format(
                                    RenderTemplate,
                                    nameof(IsPermittedToLogon),
                                    "fas fa-sign-in-alt",
                                    "black"),
                                String.Format(
                                    RenderTemplate,
                                    nameof(IsPermittedToLogon),
                                    "fas fa-sign-in-alt",
                                    "lightgray"))
                                )).ToStatement(),
                    JavascriptBinaryExpression.CreateExpression(
                        JavascriptBinaryOperators.ADD_EQ,
                        ret,
                        JavascriptInvokeExpression.CreateInvoke(
                            GetBoolIconColumnJsFunction1(
                                nameof(IsExternalLogonProvider).ToCamelCase(),
                                String.Format(
                                    RenderTemplate,
                                    nameof(IsExternalLogonProvider),
                                    "fas fa-external-link-alt",
                                    "black"),
                                String.Format(
                                    RenderTemplate,
                                    nameof(IsExternalLogonProvider),
                                    "fas fa-external-link-alt",
                                    "lightgray"))
                                )).ToStatement(),
                    JavascriptBinaryExpression.CreateExpression(
                        JavascriptBinaryOperators.ADD_EQ,
                        ret,
                        JavascriptInvokeExpression.CreateInvoke(
                            GetBoolIconColumnJsFunction1(
                                nameof(IsSystemUser).ToCamelCase(),
                                String.Format(
                                    RenderTemplate,
                                    nameof(IsSystemUser),
                                    "fas fa-desktop",
                                    "black"),
                                String.Format(
                                    RenderTemplate,
                                    nameof(IsSystemUser),
                                    "fas fa-desktop",
                                    "lightgray"))
                                )).ToStatement(),
                    JavascriptBinaryExpression.CreateExpression(
                        JavascriptBinaryOperators.ADD_EQ,
                        ret,
                        JavascriptInvokeExpression.CreateInvoke(
                            GetBoolIconColumnJsFunction1(
                                nameof(IsEmployee).ToCamelCase(),
                                String.Format(
                                    RenderTemplate,
                                    nameof(IsEmployee),
                                    "fas fa-building",
                                    "black"),
                                String.Format(
                                    RenderTemplate,
                                    nameof(IsEmployee),
                                    "fas fa-building",
                                    "lightgray"))
                                )).ToStatement(),
                    JavascriptBinaryExpression.CreateExpression(
                        JavascriptBinaryOperators.ADD_EQ,
                        ret,
                        JavascriptInvokeExpression.CreateInvoke(
                            GetBoolIconColumnJsFunction1(
                                nameof(IsSalesperson).ToCamelCase(),
                                String.Format(
                                    RenderTemplate,
                                    nameof(IsSalesperson),
                                    "fas fa-dollar-sign",
                                    "black"),
                                String.Format(
                                    RenderTemplate,
                                    nameof(IsSalesperson),
                                    "fas fa-dollar-sign",
                                    "lightgray"))
                                )).ToStatement(),
                    JavascriptReturnStatement.CreateReturn(ret)))
            .AddParameters(data, type, row, meta);
        }

        //example using switch builder
        private JavascriptFunction GetBoolIconColumnJsFunction1(string dataChild, string htmlTrue, string htmlFalse)
        {
            var data = JavascriptVariableExpression.CreateVariable("data");

            return JavascriptFunction.CreateFunction(
                JavascriptStatementBlock.CreateBlock(
                    JavascriptSwitchStatement.CreateSwitch(data.Child(dataChild))
                    .AddCaseBlock(JavascriptSwitchCaseBlock.CreateCase()
                        .AddCase(JavascriptConstantExpression<bool>.CreateConstant(true))
                            .AddStatements(JavascriptReturnStatement.CreateReturn(
                                JavascriptConstantExpression<string>.CreateConstant(htmlTrue))))
                    .AddCaseBlock(JavascriptSwitchCaseBlock.CreateCase()
                        .AddCase(JavascriptConstantExpression<bool>.CreateConstant(false))
                            .AddStatements(JavascriptReturnStatement.CreateReturn(
                                JavascriptConstantExpression<string>.CreateConstant(htmlFalse))))))
            .AddParameters(data);
        }

        //example using if/else builder
        private JavascriptFunction GetBoolIconColumnJsFunction2(string dataChild, string htmlTrue, string htmlFalse)
        {
            var data = JavascriptVariableExpression.CreateVariable("data");

            return JavascriptFunction.CreateFunction(
                JavascriptStatementBlock.CreateBlock(
                    JavascriptIfElseStatement.CreateIfElseStatement(
                        data.Child(dataChild),
                        JavascriptStatementBlock.CreateBlock(
                            JavascriptReturnStatement.CreateReturn(
                                JavascriptConstantExpression<string>.CreateConstant(htmlTrue))),
                        JavascriptStatementBlock.CreateBlock(
                            JavascriptReturnStatement.CreateReturn(
                                JavascriptConstantExpression<string>.CreateConstant(htmlFalse))))))
            .AddParameters(data);
        }

        //example using ternary operator
        private JavascriptFunction GetBoolIconColumnJsFunction3(string dataChild, string htmlTrue, string htmlFalse)
        {
            var data = JavascriptVariableExpression.CreateVariable("data");

            return JavascriptFunction.CreateFunction(
                JavascriptStatementBlock.CreateBlock(
                    JavascriptReturnStatement.CreateReturn(
                        JavascriptTernaryExpression.CreateTernary(
                            data.Child(dataChild),
                            JavascriptConstantExpression<string>.CreateConstant(htmlTrue),
                            JavascriptConstantExpression<string>.CreateConstant(htmlFalse)))))
            .AddParameters(data);
        }
    }
}
