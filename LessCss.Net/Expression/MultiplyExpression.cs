using System;
using System.Collections.Generic;
using LessCss.Expression;

namespace LessCss.Expression
{
	internal class MultiplyExpression : CompoundStyleExpression
	{
		public MultiplyExpression(StyleExpression expression, StyleExpression styleExpression) : base(expression, styleExpression) {}

		public override StyleExpression Reduce(List<StyleVariable> variables)
		{
			base.Reduce(variables);
			if(Left is ConstantExpression && Right is ConstantExpression)
			{
				var val = Multiply(Left as ConstantExpression, Right as ConstantExpression);
				return new ConstantExpression(val);
			}
			return this;
		}

		private StyleValue Multiply(ConstantExpression left, ConstantExpression right)
		{
			return left.Value * right.Value;
		}
	}
}