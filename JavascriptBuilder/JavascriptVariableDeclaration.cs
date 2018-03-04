using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Javascript.Builder
{
    public class JavascriptVariableDeclaration : JavascriptStatement
    {
        public JavascriptVariableExpression Var { get; set; }
        public IJavascriptExpression InitValue { get; set; }

        public override string BuildJavascript()
        {
            if (Var == null)
                throw new ArgumentException(String.Format("{0} cannot be null.", nameof(Var)));

            if (InitValue != null)
                return String.Format("var {0} = {1};", Var.BuildJavascript(), InitValue.BuildJavascript());

            return String.Format("var {0};", Var.BuildJavascript());
        }

        public static JavascriptVariableDeclaration CreateDeclaration(JavascriptVariableExpression _var)
        {
            return CreateDeclaration(_var, null);
        }

        public static JavascriptVariableDeclaration CreateDeclaration(JavascriptVariableExpression _var, IJavascriptExpression initValue)
        {
            return new JavascriptVariableDeclaration
            {
                Var = _var,
                InitValue = initValue
            };
        }
    }
}
