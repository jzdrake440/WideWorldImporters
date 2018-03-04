using System;

namespace Javascript.Builder
{
    public abstract class JavascriptConstantExpression : IJavascriptExpression
    {
        public abstract string BuildJavascript();
    }

    public class JavascriptConstantExpression<T> : JavascriptConstantExpression
    {
        public T Value { get; set; }

        public override string BuildJavascript()
        {
            if (Value is IJavascriptExpression jsValue)
                return jsValue.BuildJavascript();

            if (typeof(T).IsPrimitive) //handle numbers, bool
                return Value.ToString();

            if (Value is DateTime) //handle dates
                return String.Format("new Date('{0:yyyy-MM-dd}T{0:H:mm:ss}Z')", Value);

            return "\"" + Value.ToString() + "\"";
        }

        public static JavascriptConstantExpression CreateConstant(T value)
        {
            return new JavascriptConstantExpression<T> { Value = value };
        }
    }
}
