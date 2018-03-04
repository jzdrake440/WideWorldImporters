using System;
using System.Collections.Generic;
using System.Text;

namespace Javascript.Builder
{
    public class JavascriptUnaryExpression : JavascriptBooleanExpression
    {
        public bool LeftOperator { get; set; } = true;
        public string Operator { get; set; }
        public JavascriptExpression Expression { get; set; }

        public override string BuildJavascript()
        {
            if (LeftOperator) //operator to the left
                return String.Format(
                    "({0} {1})",
                    Operator,
                    Expression.BuildJavascript());

            return String.Format(//operator to the right
                "({0} {1})",
                Expression.BuildJavascript(),
                Operator);
        }
    }

    public static class JavascriptUnaryOperators
    {
        public static readonly string DELETE = "delete";
        public static readonly string TYPE_OF = "typeof";
        public static readonly string VOID = "void";
        public static readonly string NOT = "!";
        public static readonly string NOT_B = "~";
        public static readonly string POS = "+";
        public static readonly string NEG = "-";
        public static readonly string INC = "++";
        public static readonly string DEC = "--";
    }
}
