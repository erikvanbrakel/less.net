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
 * File: StyleProperty.cs
 */
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Antlr.Runtime.Tree;
using LessCss.Expression;

namespace LessCss
{
	public class StyleProperty
	{
		public string Name = string.Empty;
		public List<StyleExpression> Values = new List<StyleExpression>();

		public static StyleProperty ParseTree(BaseTree tree)
		{
			var property = new StyleProperty {Name = ((BaseTree) tree.Children[0]).Text};

			for(var i=1; i<tree.ChildCount;i++)
			{
				var node = tree.GetChild(i);
				if(node.Text == "EXPR")
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

		public virtual string ToCss(List<StyleVariable> variables)
		{
			var output = new StringBuilder();
			output.Append(Name);
			output.Append(":");
			output.Append(string.Join(" ", Values.Select(v => v.Reduce(variables).ToString()).ToArray()));
			output.Append(";");
			return output.ToString();
		}

		public bool Equals(StyleProperty obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			return Equals(obj.Name, Name) && obj.Values.SequenceEqual(Values);
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			if (obj.GetType() != typeof (StyleProperty)) return false;
			return Equals((StyleProperty) obj);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				return (Name.GetHashCode()*397) ^ Values.GetHashCode();
			}
		}
	}
}