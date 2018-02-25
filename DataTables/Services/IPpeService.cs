using System;
using System.Linq.Expressions;

namespace DataTables.Services
{
    public interface IPpeService
    {
        void AddExpression<T>(string propertyName, Func<Expression, Expression> expressionFunc);
        Expression GetExpression<T>(Expression parameter, string propertyName);
    }
}