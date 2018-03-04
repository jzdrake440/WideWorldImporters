using System;
using System.Collections.Generic;
using System.Text;

namespace Javascript.Builder
{
    public class JavascriptObject : JavascriptExpression
    {
        private Dictionary<JavascriptVariableExpression,JavascriptExpression> vars 
            = new Dictionary<JavascriptVariableExpression, JavascriptExpression>();

        public void AddVariable(JavascriptVariableExpression v)
        {
            vars.Add(v, null);
        }

        public void AddVariable(JavascriptVariableExpression v, JavascriptExpression e)
        {
            vars.Add(v, e);
        }

        public override string BuildJavascript()
        {
            StringBuilder builder = new StringBuilder();
            foreach (var v in vars)
            {
                builder.AppendFormat("{0}: {1},", v.Key.BuildJavascript(), v.Value.BuildJavascript());
            }

            return String.Format("{{{0}}}", builder);
        }
    }
}
