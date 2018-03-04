using System.Collections.Generic;
using System.Text;

namespace Javascript.Builder
{
    public abstract class JavascriptExpression : IJavascriptExpression
    {
        public abstract string BuildJavascript();

        public JavascriptExpressionStatement ToStatement()
        {
            return JavascriptExpressionStatement.CreateStatement(this);
        }
    }
}
