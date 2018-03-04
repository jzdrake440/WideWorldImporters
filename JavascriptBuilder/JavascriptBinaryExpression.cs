using System;
using System.Collections.Generic;
using System.Text;

namespace Javascript.Builder
{
    public class JavascriptBinaryExpression : JavascriptExpression
    {
        public string Operator { get; set; }
        public IJavascriptExpression LeftExpression { get; set; }
        public IJavascriptExpression RightExpression { get; set; }

        public override string BuildJavascript()
        {
            return String.Format(
                "({0} {1} {2})",
                LeftExpression.BuildJavascript(),
                Operator,
                RightExpression.BuildJavascript());
        }

        public static JavascriptBinaryExpression CreateExpression(
            string _operator,
            IJavascriptExpression leftExpression,
            IJavascriptExpression rightExpression)
        {
            return new JavascriptBinaryExpression
            {
                Operator = _operator,
                LeftExpression = leftExpression,
                RightExpression = rightExpression
            };
        }
    }

    public static class JavascriptBinaryOperators
    {
        public static readonly string MUL = "*";
        public static readonly string MUL_EQ = "*=";
        public static readonly string DIV = "/";
        public static readonly string DIV_EQ = "/=";
        public static readonly string MOD = "%";
        public static readonly string MOD_EQ = "%=";
        public static readonly string ADD = "+";
        public static readonly string ADD_EQ = "+=";
        public static readonly string SUB = "-";
        public static readonly string SUB_EQ = "-=";
        public static readonly string LSH = "<<";
        public static readonly string RSH_S = ">>";
        public static readonly string RSH_U = ">>>";
        public static readonly string AND_B = "&";
        public static readonly string XOR = "^";
        public static readonly string OR_B = "|";
        public static readonly string GT = ">";
        public static readonly string GTE = ">=";
        public static readonly string LT = "<";
        public static readonly string LTE = "<=";
        public static readonly string INSTANCE_OF = "instanceof";
        public static readonly string IN = "in";
        public static readonly string EQ = "==";
        public static readonly string EQ_S = "===";
        public static readonly string NE = "!=";
        public static readonly string NE_S = "!==";
        public static readonly string OR = "||";
        public static readonly string AND = "&&";
    }
}
