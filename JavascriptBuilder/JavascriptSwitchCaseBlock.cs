using System;
using System.Collections.Generic;
using System.Text;

namespace Javascript.Builder
{
    public class JavascriptSwitchCaseBlock : JavascriptStatementBlock //TODO change the inheritance, this is messy
    {
        private List<JavascriptConstantExpression> Cases = new List<JavascriptConstantExpression>();
        public bool Default { get; set; } = false;

        public JavascriptSwitchCaseBlock AddCase(JavascriptConstantExpression value)
        {
            Cases.Add(value);
            return this;
        }

        //change the return type to maintain builder contract
        public new JavascriptSwitchCaseBlock AddStatements(params IJavascriptStatement[] statements)
        {
            base.AddStatements(statements);
            return this;
        }

        public override string BuildJavascript()
        {
            var builder = new StringBuilder();

            foreach (var val in Cases)
                builder.AppendFormat("case {0}: ", val.BuildJavascript());

            if (Default)
                builder.Append("default:");

            foreach (var stat in Content)
                builder.Append(stat.BuildJavascript());

            return builder.ToString();
        }

        public static JavascriptSwitchCaseBlock CreateCase()
        {
            return CreateCase(false);
        }

        public static JavascriptSwitchCaseBlock CreateCase(bool _default)
        {
            return new JavascriptSwitchCaseBlock { Default = _default };
        }
    }
}
