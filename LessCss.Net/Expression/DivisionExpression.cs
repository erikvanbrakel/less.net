using System;
using System.Collections.Generic;
using LessCss.Expression;

namespace LessCss.Expression
{
	internal class DivisionExpression : CompoundStyleExpression
	{
		public DivisionExpression(StyleExpression expression, StyleExpression styleExpression) : base(expression, styleExpression) {}
		public override StyleExpression Reduce(List<StyleVariable> variables)
		{
			base.Reduce(variables);
			if (Left is ConstantExpression && Right is ConstantExpression)
			{
				var val = Divide(Left as ConstantExpression, Right as ConstantExpression);
				return new ConstantExpression(val);
			}
			return this;
		}

		private StyleValue Divide(ConstantExpression left, ConstantExpression right)
		{
			return left.Value / right.Value;
		}
	}
}