using System;
using System.Collections.Generic;
using System.Text;

namespace Javascript.Builder
{
    public abstract class JavascriptStatement : IJavascriptStatement
    {
        public abstract string BuildJavascript();
    }
}
