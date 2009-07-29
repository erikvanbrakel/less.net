/* Copyright 2009 Erik van Brakel
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *	
 *	http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License. 
 * File: StyleDocument.cs
 */
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Antlr.Runtime;
using Antlr.Runtime.Tree;

namespace LessCss
{
	public class StyleDocument
	{
		internal readonly List<StyleVariable> Variables = new List<StyleVariable>();
		public List<StyleRule> Rules = new List<StyleRule>();

		private StyleDocument() { }

		public static StyleDocument FromFile(string filename)
		{
			return FromString(File.ReadAllText(filename));
		}

		public static StyleDocument FromString(string input)
		{
			var stream = new ANTLRStringStream(input);
			var lexer = new lesscssLexer(stream);
			var parser = new lesscssParser(new CommonTokenStream(lexer));
			var root = parser.lessCss();

			return ParseTree((BaseTree)root.Tree);
		}

		private static StyleDocument ParseTree(BaseTree tree)
		{
			var document = new StyleDocument();
			foreach (BaseTree child in tree.Children)
			{
				switch (child.Text)
				{
					case "VAR":
						var variable = StyleVariable.ParseTree(child);
						document.AddVariable(variable);
						break;
					case "RULE":
						var rule = StyleRule.ParseTree(child);
						document.AddRule(rule);
						break;
				}
			}
			return document;
		}

		private void AddVariable(StyleVariable variable)
		{
			Variables.Add(variable);
		}

		private void AddRule(StyleRule rule)
		{
			Rules.Add(rule);
		}

		public string ToCss()
		{
			var sb = new StringBuilder();
			Rules.ForEach(r => sb.AppendLine(r.ToCss()));
			return sb.ToString();
		}

		public StyleDocument Flatten()
		{
			var doc = MemberwiseClone() as StyleDocument;
			doc.Rules = doc.Rules.SelectMany(r => r.Flatten()).ToList();
			return doc;
		}

		public StyleDocument Merge()
		{
			var doc = MemberwiseClone() as StyleDocument;
			var newRules = new List<StyleRule>();
			foreach (var selectorGroup in doc.Rules.GroupBy(r => r.GetSelector()))
			{
				var rule = new StyleRule();
				rule.Selectors.Add(new StyleSelector { Name = selectorGroup.Key });
				rule.Properties.AddRange(selectorGroup.SelectMany(r => r.Properties).Distinct());
				newRules.Add(rule);
			}
			doc.Rules = newRules;
			return doc;
		}
	}
}