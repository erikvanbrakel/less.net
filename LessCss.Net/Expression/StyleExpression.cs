using System.Collections.Generic;
using Antlr.Runtime.Tree;
using LessCss.Expression;

namespace LessCss.Expression
{
	public class StyleExpression
	{
		public virtual string Eval(List<StyleVariable> a)
		{
			return "";
		}

		public virtual StyleExpression Reduce(List<StyleVariable> variables)
		{
			return this;
		}
	}

	internal class LiteralExpression : StyleExpression
	{
		private readonly string value;

		public override string ToString()
		{
			return value;
		}
		public LiteralExpression(ITree tree)
		{
			for(int i = 0; i<tree.ChildCount;i++)
			{
				value += tree.GetChild(i).Text;
			}
		}

		public LiteralExpression(string val)
		{
			this.value = val;
		}

		public LiteralExpression()
		{
			value = "";
		}

		public override StyleExpression Reduce(List<StyleVariable> variables)
		{
			return this;
		}

		public override string Eval(List<StyleVariable> a)
		{
			return value;
		}
	}
}