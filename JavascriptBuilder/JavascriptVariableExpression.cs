using System;
using System.Collections.Generic;
using System.Text;

namespace Javascript.Builder
{
    public class JavascriptVariableExpression : JavascriptExpression
    {
        private Dictionary<string, JavascriptVariableExpression> children =
            new Dictionary<string, JavascriptVariableExpression>();

        public string Name { get; set; }

        public override string BuildJavascript()
        {
            if (Name == null)
                throw new ArgumentException(String.Format("{0} cannot be null.", nameof(Name)));

            return Name;
        }

        public JavascriptVariableExpression Child(string name)
        {
            if (!children.ContainsKey(name))
                children[name] = CreateVariable(Name + "." + name);

            return children[name];
        }

        public static JavascriptVariableExpression CreateVariable(string name)
        {
            return new JavascriptVariableExpression { Name = name };
        }
    }
}
