using DataTables.Models;
using DataTables.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace WideWorldImporters.DataTables
{
    public class WwiBllPpeProfile : IPpeProfile
    {
        public PpeService BuildService()
        {
            PpeService ppeService = new PpeService();

            //examples from previous project

            ////Customer.CustomerType
            //ppeService.AddExpression<Customer>(nameof(CustomerBl.CustomerType), pe =>
            //{
            //    var storeProperty = Expression.Property(pe, nameof(Customer.Store));
            //    var personProperty = Expression.Property(pe, nameof(Customer.Person));

            //    var isStoreNotNull = ExpressionUtility.IsNotNull(storeProperty);
            //    var isPersonNotNull = ExpressionUtility.IsNotNull(personProperty);

            //    return Expression.Condition(isPersonNotNull,
            //        Expression.Constant(CustomerType.PERSON.GetDisplayValue()),
            //        Expression.Condition(isStoreNotNull,
            //            Expression.Constant(CustomerType.STORE.GetDisplayValue()),
            //            Expression.Constant(CustomerType.UNKNOWN.GetDisplayValue())));
            //});

            ////Customer.DisplayName
            //ppeService.AddExpression<Customer>(nameof(CustomerBl.DisplayName), pe =>
            //{
            //    var storeProperty = Expression.Property(pe, nameof(Customer.Store));
            //    var personProperty = Expression.Property(pe, nameof(Customer.Person));

            //    var storeName = Expression.Property(storeProperty, nameof(Store.Name));
            //    var personName = ppeService.GetExpression<Person>(personProperty, nameof(PersonBl.DisplayName));

            //    var isStoreNotNull = ExpressionUtility.IsNotNull(storeProperty);
            //    var isPersonNotNull = ExpressionUtility.IsNotNull(personProperty);

            //    return Expression.Condition(isPersonNotNull,
            //        personName,
            //        Expression.Condition(isStoreNotNull,
            //            storeName,
            //            Expression.Constant(CustomerType.UNKNOWN.GetDisplayValue())));
            //});

            ////Person.DisplayName
            //ppeService.AddExpression<Person>(nameof(PersonBl.DisplayName), pe =>
            //{
            //    var lastNameProperty = Expression.Property(pe, nameof(Person.LastName));
            //    var firstNameProperty = Expression.Property(pe, nameof(Person.FirstName));
            //    var separatorExpression = Expression.Constant(", ");

            //    var concatMethod = typeof(string).GetMethod(nameof(String.Concat), new[] { typeof(string), typeof(string)});

            //    return Expression.Add( //using Expression.Add instead of Expression.Call because the translator has difficulties translating String.Concat
            //        lastNameProperty, 
            //        Expression.Add(
            //            separatorExpression, 
            //            firstNameProperty, 
            //            concatMethod), 
            //        concatMethod);
            //});

            return ppeService;
        }
    }
}
