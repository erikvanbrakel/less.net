using System.Collections.Generic;
using LessCss.Expression;

namespace LessCss.Expression
{
	internal abstract class CompoundStyleExpression : StyleExpression
	{
		protected StyleExpression Left;
		protected StyleExpression Right;

		protected CompoundStyleExpression(StyleExpression left, StyleExpression right)
		{
			Left = left;
			Right = right;
		}

		public override StyleExpression Reduce(List<StyleVariable> variables)
		{
			Left = Left.Reduce(variables);
			Right = Right.Reduce(variables);
			return this;
		}

		public bool Equals(CompoundStyleExpression obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			return Equals(obj.Left, Left) && Equals(obj.Right, Right);
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			if (obj.GetType() != typeof (CompoundStyleExpression)) return false;
			return Equals((CompoundStyleExpression) obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				return (Left.GetHashCode()*397) ^ Right.GetHashCode();
			}
		}
	}
}