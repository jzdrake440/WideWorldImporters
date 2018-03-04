using System;
using System.Collections.Generic;
using System.Text;

namespace Javascript.Builder
{
    public class JavascriptStatementBlock : IJavascriptStatementBlock
    {
        protected List<IJavascriptStatement> Content = new List<IJavascriptStatement>();

        public JavascriptStatementBlock AddStatements(params IJavascriptStatement[] statements)
        {
            Content.AddRange(statements);
            return this;
        }

        public bool IsEmpty()
        {
            return Content.Count == 0;
        }

        public bool CanReduce()
        {
            return Content.Count <= 1;
        }

        public virtual string BuildJavascript()
        {
            return BuildJavascript(false);
        }

        public string BuildJavascript(bool reduce)
        {
            if (reduce && CanReduce())
                return IsEmpty() ? "" : Content[0].BuildJavascript();

            var builder = new StringBuilder();

            foreach (var statement in Content)
                builder.Append(statement.BuildJavascript());

            return String.Format("{{ {0} }}", builder);
        }

        public static JavascriptStatementBlock CreateBlock()
        {
            return CreateBlock(Array.Empty<IJavascriptStatement>());
        }

        public static JavascriptStatementBlock CreateBlock(params IJavascriptStatement[] content)
        {
            var ret = new JavascriptStatementBlock();
            ret.AddStatements(content);

            return ret;
        }
    }
}
