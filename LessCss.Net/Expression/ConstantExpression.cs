using System;
using System.Collections.Generic;
using Antlr.Runtime.Tree;
using LessCss.Expression;

namespace LessCss.Expression
{
	internal class ConstantExpression : StyleExpression
	{
		public readonly StyleValue Value;

		public ConstantExpression(StyleValue value)
		{
			Value = value;
		}

		public ConstantExpression()
		{
			
		}

		public ConstantExpression(ITree tree)
		{
			var val = tree.GetChild(0).Text;
			var node = tree.GetChild(1);
			if (val.StartsWith("#"))
			{
				Value = new StyleColor(val);
			}
			else
			{
				Value = new StyleNumber(Convert.ToDecimal(val), node != null ? node.Text : "");
			}
		}

		public override StyleExpression Reduce(List<StyleVariable> variables)
		{
			return this;
		}

		public override string ToString()
		{
			return Value.ToString();
		}

		public bool Equals(ConstantExpression obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			return Equals(obj.Value, Value);
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			if (obj.GetType() != typeof (ConstantExpression)) return false;
			return Equals((ConstantExpression) obj);
		}

		public override int GetHashCode()
		{
			return Value.GetHashCode();
		}
	}
}