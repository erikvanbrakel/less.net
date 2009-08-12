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
 * File: StyleVariable.cs
 */
using System.Collections.Generic;
using Antlr.Runtime.Tree;
using LessCss.Expression;

namespace LessCss
{
	public class StyleVariable
	{
		public string Name;
		public StyleExpression Value;

		public static StyleVariable ParseTree(ITree tree)
		{
			var name = tree.GetChild(0).Text;
			var variable = new StyleVariable {Name = name};
			switch(tree.GetChild(1).Text)
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

		public string Eval(List<StyleVariable> a)
		{
			return Value.Eval(a);
		}

		public void Reduce(List<StyleVariable> variables)
		{
			Value = Value.Reduce(variables);
		}
	}
}