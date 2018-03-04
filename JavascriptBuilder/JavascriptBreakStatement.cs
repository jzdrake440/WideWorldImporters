using System;
using System.Collections.Generic;
using System.Text;

namespace Javascript.Builder
{
    public class JavascriptBreakStatement : JavascriptStatement
    {
        public override string BuildJavascript()
        {
            return "break;";
        }
    }
}
