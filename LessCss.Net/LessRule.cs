using System.Collections.Generic;
using System.Linq;
using System.Text;
using Antlr.Runtime.Tree;

namespace LessCss
{
	public class LessRule
	{
		private readonly List<LessSelector> Selectors = new List<LessSelector>();
		private readonly List<LessProperty> Properties = new List<LessProperty>();
		private readonly List<LessRule> Rules = new List<LessRule>();

		public static LessRule ParseTree(BaseTree tree)
		{
			var rule = new LessRule();
			foreach(BaseTree child in tree.Children)
			{
				switch(child.Text)
				{
					case "PROPERTY":
						rule.Properties.Add(LessProperty.ParseTree(child));
						break;
					case "RULE":
						rule.Rules.Add(LessRule.ParseTree(child));
						break;
					case "SELECTOR":
						foreach(BaseTree selectorNode in child.Children)
						{
							rule.Selectors.Add(LessSelector.ParseTree(selectorNode));
						}
						break;
				}
			}
			return rule;
		}

		public string PrettyPrint()
		{
			return PrettyPrint(1);
		}

		public string PrettyPrint(int tabcount)
		{
			var sb = new StringBuilder();
			var tabs = new string(' ', tabcount*2);

			if (Selectors.Count > 0)
			{
				sb.Append(tabs);
				sb.AppendLine("Selectors:");
				Selectors.ForEach(s =>
				                  	{
				                  		sb.Append(tabs);
				                  		sb.Append("  ");
				                  		sb.AppendLine(s.PrettyPrint());
				                  	});
			}
			if (Properties.Count > 0)
			{
				sb.Append(tabs);
				sb.AppendLine("Properties:");
				Properties.ForEach(p =>
				                   	{
				                   		sb.Append(tabs);
				                   		sb.Append("  ");
				                   		sb.AppendLine(p.PrettyPrint());
				                   	});
			}
			if (Rules.Count > 0)
			{
				sb.Append(tabs);
				sb.AppendLine("Rules:");
				Rules.ForEach(r => sb.AppendLine(r.PrettyPrint(tabcount + 1)));
			}
			return sb.ToString();
		}

		public string ToCss()
		{
			return ToCss(string.Empty);
		}
		
		private string ToCss(string parentSelectors)
		{
			var sb = new StringBuilder();
			var selectorBuilder = new StringBuilder();
			selectorBuilder.Append(parentSelectors);
//			if (!string.IsNullOrEmpty(parentSelectors)) sb.Append(' ');
			selectorBuilder.Append(string.Join(", ",Selectors.Select(s => s.ToCss()).ToArray()));
			sb.Append(selectorBuilder);
			sb.Append(" {");
			Properties.ForEach(p => sb.Append(p.ToCss() + " "));
			sb.AppendLine("}");
			Rules.ForEach(r => sb.Append(r.ToCss(selectorBuilder + " ")));
			return sb.ToString();
		}
	}
}