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
 * File: StyleRule.cs
 */
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Antlr.Runtime.Tree;

namespace LessCss
{
	public class StyleRule
	{
		public List<StyleSelector> Selectors = new List<StyleSelector>();
		public List<StyleProperty> Properties = new List<StyleProperty>();
		public readonly List<StyleRule> Rules = new List<StyleRule>();

		public string GetSelector()
		{
			return string.Join(",", Selectors.Select(s => s.Name).ToArray());
		}
		public IEnumerable<StyleRule> Flatten()
		{
			var flatrules = Rules.SelectMany(r => r.Flatten());
			var flatselector = GetSelector();
			foreach(var rule in flatrules)
			{
			    rule.Selectors.ForEach(s => s.Name = flatselector + " " + s.Name);
			    yield return rule;
			}
			var current = MemberwiseClone() as StyleRule;
			current.Rules.Clear();
			yield return current;
		}

		public static StyleRule ParseTree(BaseTree tree)
		{
			var rule = new StyleRule();
			foreach(BaseTree child in tree.Children)
			{
				switch(child.Text)
				{
					case "PROPERTY":
						rule.Properties.Add(StyleProperty.ParseTree(child));
						break;
					case "RULE":
						rule.Rules.Add(StyleRule.ParseTree(child));
						break;
					case "SELECTOR":
						rule.Selectors.Add(StyleSelector.ParseTree(child));
						break;
				}
			}
			return rule;
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
			selectorBuilder.Append(string.Join(", ",Selectors.Select(s => s.ToCss()).ToArray()));

			if (Properties.Count > 0)
			{
				sb.Append(selectorBuilder);
				sb.Append(" {");
				Properties.ForEach(p => sb.Append(p.ToCss() + " "));
				sb.Append("}");
			}
			Rules.ForEach(r => sb.Append(r.ToCss(selectorBuilder + " ")));
			return sb.ToString();
		}
	}
}