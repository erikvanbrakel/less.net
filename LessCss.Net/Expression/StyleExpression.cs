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

		public static StyleExpression ParseExpression(ITree node)
		{
			var text = node.Text;
			switch (text)
			{
				case "+":
					return new AddExpression(ParseExpression(node.GetChild(0)), ParseExpression(node.GetChild(1)));
				case "*":
					return new MultiplyExpression(ParseExpression(node.GetChild(0)), ParseExpression(node.GetChild(1)));
				case "/":
					return new DivisionExpression(ParseExpression(node.GetChild(0)), ParseExpression(node.GetChild(1)));
				case "-":
					return new SubtractExpression(ParseExpression(node.GetChild(0)), ParseExpression(node.GetChild(1)));
				case "CONSTANT":
					return new ConstantExpression(node);
				case "VAR":
					return new VarExpression(node.GetChild(0).Text);
				default:
					return new ConstantExpression();
			}
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