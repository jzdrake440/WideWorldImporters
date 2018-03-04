using System;
using System.Collections.Generic;
using System.Text;

namespace Javascript.Builder
{
    public abstract class JavascriptBooleanExpression : IJavascriptBooleanExpression
    {
        public abstract string BuildJavascript();
    }
}
