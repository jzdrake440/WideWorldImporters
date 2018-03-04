using System;
using System.Collections.Generic;
using System.Text;

namespace Javascript.Builder
{
    public class JavascriptReturnStatement : JavascriptStatement
    {
        public IJavascriptExpression ReturnExpression { get; set; }

        public override string BuildJavascript()
        {
            return String.Format("return {0};", ReturnExpression.BuildJavascript());
        }

        public static JavascriptReturnStatement CreateReturn(IJavascriptExpression expression)
        {
            return new JavascriptReturnStatement { ReturnExpression = expression };
        }
    }
}
