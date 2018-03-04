using System;
using System.Collections.Generic;
using System.Text;

namespace Javascript.Builder
{
    public class JavascriptTernaryExpression : JavascriptExpression
    {
        public IJavascriptExpression Condition { get; set; }
        public IJavascriptExpression TrueExpression { get; set; }
        public IJavascriptExpression FalseExpression { get; set; }

        public override string BuildJavascript()
        {
            return String.Format(
                "({0} ? {1} : {2})",
                Condition.BuildJavascript(),
                TrueExpression.BuildJavascript(),
                FalseExpression.BuildJavascript());
        }

        public static JavascriptTernaryExpression CreateTernary(
            IJavascriptExpression condition, 
            IJavascriptExpression trueExpression, 
            IJavascriptExpression falseExpression)
        {
            return new JavascriptTernaryExpression
            {
                Condition = condition,
                TrueExpression = trueExpression,
                FalseExpression = falseExpression
            };
        }
    }
}
