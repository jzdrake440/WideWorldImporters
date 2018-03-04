using System;
using System.Collections.Generic;
using System.Text;

namespace Javascript.Builder
{
    public class JavascriptSwitchStatement : JavascriptStatement
    {
        public JavascriptVariableExpression Expression { get; set; } 

        private List<JavascriptSwitchCaseBlock> Cases = new List<JavascriptSwitchCaseBlock>();

        public JavascriptSwitchStatement AddCaseBlock(JavascriptSwitchCaseBlock _case)
        {
            Cases.Add(_case);
            return this;
        }

        public override string BuildJavascript()
        {
            var builder = new StringBuilder();
            foreach (var _case in Cases)
                builder.Append(_case.BuildJavascript());

            return String.Format("switch({0}) {{{1}}}", Expression.BuildJavascript(), builder.ToString());
        }

        public static JavascriptSwitchStatement CreateSwitch(JavascriptVariableExpression switchExpression)
        {
            return new JavascriptSwitchStatement { Expression = switchExpression };
        }
    }
}
