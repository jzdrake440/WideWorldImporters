using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace WideWorldImporters.Design
{
    public class WwiPluralizer : IPluralizer
    {
        private readonly Inflector.Inflector inflector = new Inflector.Inflector(Thread.CurrentThread.CurrentUICulture);

        public string Pluralize(string identifier)
        {
            switch (identifier)
            {
                case "People":
                    return identifier;
                default:
                    return inflector.Pluralize(identifier);
            }
        }

        public string Singularize(string identifier)
        {
            return inflector.Singularize(identifier);
        }
    }
}
