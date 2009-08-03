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
using System;
using System.Collections.Generic;
using Antlr.Runtime.Tree;

namespace LessCss
{

	public class StyleExpression
	{
		private string varname;
		public static StyleExpression ParseTree(BaseTree tree)
		{
			var expression = new StyleExpression();
			expression.varname = tree.GetChild(0).Text;
			return expression;
		}

		public string Eval(List<StyleVariable> a)
		{
			var variable = a.Find(v => v.Name == varname);
			return variable == null ? "" : variable.Value;
		}
	}

	public class ComputedStyleProperty : StyleProperty
	{
		public string Key;
		public ComputedStyleProperty(ITree tree)
		{
			Name = tree.GetChild(0).Text;
			Key = tree.GetChild(1).GetChild(0).Text;
		}
	}
	public class StyleProperty
	{
		public string Name = string.Empty;
		public string Value = string.Empty;

		public static StyleProperty ParseTree(BaseTree tree)
		{
			var property = new StyleProperty {Name = ((BaseTree) tree.Children[0]).Text};

			var val = "";
			for(var i=1; i<tree.Children.Count;i++)
			{
				var node = (BaseTree)tree.Children[i];
				if(node.Text == "EXPRESSION")
				{
					return new ComputedStyleProperty(tree);
				}
				val += " " + node.Text;
			}

			property.Value = val;

			return property;
		}

		public string ToCss()
		{
			return string.Format("{0}:{1};",Name, Value);
		}

		public bool Equals(StyleProperty obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			return Equals(obj.Name, Name) && Equals(obj.Value, Value);
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
				return (Name.GetHashCode()*397) ^ Value.GetHashCode();
			}
		}
	}
}