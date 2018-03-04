using System;
using System.Collections.Generic;
using System.Text;

namespace Javascript.Builder
{
    public class JavascriptFunction : JavascriptExpression
    {
        public string Name { get; set; }

        private List<JavascriptVariableExpression> variableExpressions = new List<JavascriptVariableExpression>();
        public JavascriptStatementBlock FunctionBlock { get; set; }

        public JavascriptFunction AddParameters(params JavascriptVariableExpression[] _params)
        {
            variableExpressions.AddRange(_params);
            return this;
        }

        public override string BuildJavascript()
        {
            var paramList = new List<string>();
            foreach (var param in variableExpressions)
            {
                paramList.Add(param.BuildJavascript());
            }

            return String.Format(
                "function {0}({1}) {2}",
                Name??"",
                String.Join(", ", paramList),
                FunctionBlock.BuildJavascript());
        }

        public static JavascriptFunction CreateFunction(JavascriptStatementBlock block)
        {
            return CreateFunction(null, block);
        }

        public static JavascriptFunction CreateFunction(string name, JavascriptStatementBlock block)
        {
            return new JavascriptFunction { Name = name, FunctionBlock = block };
        }
    }
}
