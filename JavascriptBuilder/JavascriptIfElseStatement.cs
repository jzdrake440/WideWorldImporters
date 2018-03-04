using System;
using System.Collections.Generic;
using System.Text;

namespace Javascript.Builder
{
    public class JavascriptIfElseStatement : JavascriptStatement
    {
        public IJavascriptExpression Condition { get; set; }
        private JavascriptStatementBlock TrueBlock { get; set; }
        private JavascriptStatementBlock FalseBlock { get; set; }

        public override string BuildJavascript()
        {
            if (FalseBlock.IsEmpty())
                return String.Format(
                    "if ({0}) {1}", 
                    Condition.BuildJavascript(), 
                    TrueBlock.BuildJavascript(true));

            return String.Format(
                "if ({0}) {1} else {2}",
                Condition.BuildJavascript(),
                TrueBlock.BuildJavascript(true),
                FalseBlock.BuildJavascript(true));
        }

        public static JavascriptIfElseStatement CreateIfElseStatement(IJavascriptExpression condition, JavascriptStatementBlock trueBlock)
        {
            return CreateIfElseStatement(condition, trueBlock, null);
        }

        public static JavascriptIfElseStatement CreateIfElseStatement(IJavascriptExpression condition, JavascriptStatementBlock trueBlock, JavascriptStatementBlock falseBlock)
        {
            return new JavascriptIfElseStatement { Condition = condition, TrueBlock = trueBlock, FalseBlock = falseBlock };
        }
    }
}
