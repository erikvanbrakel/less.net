using System.Linq;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using LessCss.Expression;

namespace LessCss.Loaders
{
	public class LessDocumentLoader : IDocumentLoader
	{
		public StyleDocument LoadFromString(string input)
		{
			var stream = new ANTLRStringStream(input);
			var lexer = new lesscssLexer(stream);
			var parser = new lesscssParser(new CommonTokenStream(lexer));
			var root = parser.lessCss();

			return ParseDocument((BaseTree)root.Tree);
		}

		private StyleDocument ParseDocument(BaseTree tree)
		{
			var document = new StyleDocument();

			if (tree.IsNil)
			{
				foreach (BaseTree child in tree.Children)
				{
					switch (child.Text)
					{
						case "VAR":
							var variable = ParseVariable(child);
							document.AddVariable(variable);
							break;
						case "RULE":
							var rule = ParseRule(child);
							document.AddRule(rule);
							break;
					}
				}
			}

			return document;
		}

		private StyleVariable ParseVariable(ITree tree)
		{
			var name = tree.GetChild(0).Text;
			var variable = new StyleVariable { Name = name };
			switch (tree.GetChild(1).Text)
			{
				case "LITERAL":
					variable.Value = new LiteralExpression(tree.GetChild(1));
					break;
				default:
					variable.Value = StyleExpression.ParseExpression(tree.GetChild(1).GetChild(0));
					break;
			}
			return variable;
		}

		private StyleRule ParseRule(BaseTree tree)
		{
			var rule = new StyleRule();

			foreach (BaseTree child in tree.Children)
			{
				switch (child.Text)
				{
					case "PROPERTY":
						rule.Properties.Add(ParseProperty(child));
						break;
					case "RULE":
						rule.Rules.Add(ParseRule(child));
						break;
					case "SELECTORGROUP":
						foreach (BaseTree selectorChild in child.Children)
						{
							rule.Selectors.Add(ParseSelector(selectorChild));
						}
						break;
					case "MIXIN":
						foreach (BaseTree selectorgroup in child.Children)
						{
							foreach (BaseTree selector in selectorgroup.Children)
								rule.Mixins.Add(ParseSelector(selector));
						}
						break;
				}
			}
			return rule;
		}

		private StyleSelector ParseSelector(BaseTree child)
		{
			var tree = child;
			var tokens = tree.Children.Cast<BaseTree>().Select(c => c.Text).ToArray();
			return new StyleSelector { Name = string.Join(" ", tokens) };
		}

		private StyleProperty ParseProperty(ITree child)
		{
			var property = new StyleProperty { Name = child.GetChild(0).Text };

			for (var i = 1; i < child.ChildCount; i++)
			{
				var node = child.GetChild(i);
				if (node.Text == "EXPR")
				{
					property.Values.Add(StyleExpression.ParseExpression(node.GetChild(0)));
				}
				else
				{
					property.Values.Add(new LiteralExpression(node.Text));
				}
			}

			return property;
		}
	}
}