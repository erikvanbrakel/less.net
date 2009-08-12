using System.Collections.Generic;

namespace LessCss.Expression
{
	internal class SubtractExpression : CompoundStyleExpression
	{
		public SubtractExpression(StyleExpression expression, StyleExpression styleExpression) : base(expression, styleExpression) {}
		public override StyleExpression Reduce(List<StyleVariable> variables)
		{
			base.Reduce(variables);
			if (Left is ConstantExpression && Right is ConstantExpression)
			{
				var val = Subtract(Left as ConstantExpression, Right as ConstantExpression);
				return new ConstantExpression(val);
			}
			return this;
		}

		private StyleValue Subtract(ConstantExpression left, ConstantExpression right)
		{
			return left.Value - right.Value;
		}
	}
}