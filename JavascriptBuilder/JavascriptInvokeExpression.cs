using System;
using System.Collections.Generic;
using System.Text;

namespace Javascript.Builder
{
    public class JavascriptInvokeExpression : JavascriptExpression
    {
        public IJavascriptExpression InvokedExpression { get; set; }
        private List<IJavascriptExpression> variableExpressions = new List<IJavascriptExpression>();

        public JavascriptInvokeExpression AddArguments(params IJavascriptExpression[] args)
        {
            variableExpressions.AddRange(args);
            return this;
        }

        public override string BuildJavascript()
        {
            return String.Format("{0}({1})", InvokedExpression.BuildJavascript(), String.Join(", ", variableExpressions));
        }

        public static JavascriptInvokeExpression CreateInvoke(IJavascriptExpression invokedExpression)
        {
            return new JavascriptInvokeExpression
            {
                InvokedExpression = invokedExpression
            };
        }
    }
}
