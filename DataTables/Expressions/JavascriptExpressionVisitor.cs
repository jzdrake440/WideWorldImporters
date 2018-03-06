using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq;

namespace DataTables.Expressions
{
    public class JavascriptExpressionVisitor : ExpressionVisitor
    {
        private StringBuilder visitBuffer = new StringBuilder();
        public string ConvertToJavascript(Expression expression)
        {
            visitBuffer.Clear();
            Visit(expression);

            return visitBuffer.ToString();
        }

        public override Expression Visit(Expression node)
        {
            return base.Visit(node);
        }

        protected override Expression VisitBinary(BinaryExpression node)
        {
            Visit(node.Left);
            visitBuffer.Append(GetOperator(node.NodeType));
            Visit(node.Right);
            return node;
        }

        protected string GetOperator(ExpressionType type)
        {
            switch (type)
            {
                case ExpressionType.Add:
                    return "+";
            }

            throw new NotImplementedException();
        }

        protected override Expression VisitBlock(BlockExpression node)
        {
            throw new NotImplementedException();
        }

        protected override CatchBlock VisitCatchBlock(CatchBlock node)
        {
            throw new NotImplementedException();
        }

        protected override Expression VisitConditional(ConditionalExpression node)
        {
            //return base.VisitConditional(node);

            visitBuffer.Append("(");
            Visit(node.Test);
            visitBuffer.Append(" ? ");
            Visit(node.IfTrue);
            visitBuffer.Append(" : ");
            Visit(node.IfFalse);
            visitBuffer.Append(")");
            return node;
        }

        protected override Expression VisitConstant(ConstantExpression node)
        {
            if (node.Type == typeof(string))
                visitBuffer.Append("\"").Append(node.Value).Append("\"");
            else
                visitBuffer.Append(node.Value);


            return node;
        }

        protected override Expression VisitDebugInfo(DebugInfoExpression node)
        {
            throw new NotImplementedException();
        }

        protected override Expression VisitDefault(DefaultExpression node)
        {
            throw new NotImplementedException();
        }

        protected override Expression VisitDynamic(DynamicExpression node)
        {
            throw new NotImplementedException();
        }

        protected override ElementInit VisitElementInit(ElementInit node)
        {
            throw new NotImplementedException();
        }

        protected override Expression VisitExtension(Expression node)
        {
            throw new NotImplementedException();
        }

        protected override Expression VisitGoto(GotoExpression node)
        {
            throw new NotImplementedException();
        }

        protected override Expression VisitIndex(IndexExpression node)
        {
            throw new NotImplementedException();
        }

        protected override Expression VisitInvocation(InvocationExpression node)
        {
            throw new NotImplementedException();
        }

        protected override Expression VisitLabel(LabelExpression node)
        {
            throw new NotImplementedException();
        }

        protected override LabelTarget VisitLabelTarget(LabelTarget node)
        {
            throw new NotImplementedException();
        }

        protected override Expression VisitLambda<T>(Expression<T> node)
        {
            var _params = from p in node.Parameters
                          select p.Name;

            visitBuffer.AppendFormat(
                "function({0}) {{ return ",
                String.Join(", ", _params)
                );

            Visit(node.Body);

            visitBuffer.Append("}");

            return node;
        }

        protected override Expression VisitListInit(ListInitExpression node)
        {
            throw new NotImplementedException();
        }

        protected override Expression VisitLoop(LoopExpression node)
        {
            throw new NotImplementedException();
        }

        protected override Expression VisitMember(MemberExpression node)
        {
            throw new NotImplementedException();
        }

        protected override MemberAssignment VisitMemberAssignment(MemberAssignment node)
        {
            throw new NotImplementedException();
        }

        protected override MemberBinding VisitMemberBinding(MemberBinding node)
        {
            throw new NotImplementedException();
        }

        protected override Expression VisitMemberInit(MemberInitExpression node)
        {
            throw new NotImplementedException();
        }

        protected override MemberListBinding VisitMemberListBinding(MemberListBinding node)
        {
            throw new NotImplementedException();
        }

        protected override MemberMemberBinding VisitMemberMemberBinding(MemberMemberBinding node)
        {
            throw new NotImplementedException();
        }

        protected override Expression VisitMethodCall(MethodCallExpression node)
        {
            throw new NotImplementedException();
        }

        protected override Expression VisitNew(NewExpression node)
        {
            throw new NotImplementedException();
        }

        protected override Expression VisitNewArray(NewArrayExpression node)
        {
            throw new NotImplementedException();
        }

        protected override Expression VisitParameter(ParameterExpression node)
        {
            visitBuffer.Append(node.Name);
            return node;
        }

        protected override Expression VisitRuntimeVariables(RuntimeVariablesExpression node)
        {
            throw new NotImplementedException();
        }

        protected override Expression VisitSwitch(SwitchExpression node)
        {
            throw new NotImplementedException();
        }

        protected override SwitchCase VisitSwitchCase(SwitchCase node)
        {
            throw new NotImplementedException();
        }

        protected override Expression VisitTry(TryExpression node)
        {
            throw new NotImplementedException();
        }

        protected override Expression VisitTypeBinary(TypeBinaryExpression node)
        {
            throw new NotImplementedException();
        }

        protected override Expression VisitUnary(UnaryExpression node)
        {
            throw new NotImplementedException();
        }
    }
}