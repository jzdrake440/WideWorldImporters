using System;
using System.Collections.Generic;
using System.Text;

namespace Javascript.Builder
{
    public class JavascriptExpressionStatement : JavascriptStatement
    {
        public IJavascriptExpression Expression { get; set; }
        public override string BuildJavascript()
        {
            return Expression.BuildJavascript() + ";";
        }

        public static JavascriptExpressionStatement CreateStatement(IJavascriptExpression expression)
        {
            return new JavascriptExpressionStatement { Expression = expression };
        }
    }
}
