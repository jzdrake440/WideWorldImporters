using System;
using System.Collections.Generic;
using System.Reflection;

namespace DataTables.TagHelpers
{
    /* as described in:
     * http://blog.techdominator.com/article/the-very-basics-of-nesting-for-tag-helpers.html
     * We need to create a custom context object because the context in the child objects
     *      will be a copy of the parents, meaning the Items property will not persist to
     *      the parent.
     */
    public class DataTableContext
    {
        public Type DtoType { get; set; }
        public readonly HashSet<PropertyInfo> ExcludeProperties = new HashSet<PropertyInfo>();
    }
}
