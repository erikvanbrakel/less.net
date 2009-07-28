using System.Collections.Generic;
using System.IO;
using System.Text;
using Antlr.Runtime;
using Antlr.Runtime.Tree;

namespace LessCss
{
	public class LessDocument
	{
		private readonly List<LessVariable> Variables = new List<LessVariable>();
		private readonly List<LessRule> Rules = new List<LessRule>();

		private LessDocument() { }

		public static LessDocument FromFile(string filename)
		{
			return FromString(File.ReadAllText(filename));
		}

		public static LessDocument FromString(string input)
		{
			var stream = new ANTLRStringStream(input);
			var lexer = new lesscssLexer(stream);
			var parser = new lesscssParser(new CommonTokenStream(lexer));
			var root = parser.lessCss();

			return ParseTree((BaseTree)root.Tree);
		}

		private static LessDocument ParseTree(BaseTree tree)
		{
			var document = new LessDocument();
			foreach (BaseTree child in tree.Children)
			{
				switch (child.Text)
				{
					case "VAR":
						var variable = LessVariable.ParseTree(child);
						document.AddVariable(variable);
						break;
					case "RULE":
						var rule = LessRule.ParseTree(child);
						document.AddRule(rule);
						break;
				}
			}
			return document;
		}

		private void AddVariable(LessVariable variable)
		{
			Variables.Add(variable);
		}

		private void AddRule(LessRule rule)
		{
			Rules.Add(rule);
		}

		public string PrettyPrint()
		{
			var sb = new StringBuilder();
			sb.AppendLine("Variables:");
			Variables.ForEach(v => sb.AppendLine("\t" + v.PrettyPrint()));
			sb.AppendLine("Rules:");
			Rules.ForEach(r => sb.AppendLine(r.PrettyPrint()));
			return sb.ToString();
		}

		public string ToCss()
		{
			var sb = new StringBuilder();
			Rules.ForEach(r => sb.AppendLine(r.ToCss()));
			return sb.ToString();
		}
	}
}