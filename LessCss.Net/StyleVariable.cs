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
using Antlr.Runtime.Tree;

namespace LessCss
{
	public class StyleVariable
	{
		public string Name;
		public string Value;

		public static StyleVariable ParseTree(BaseTree tree)
		{
			var variable = new StyleVariable { Name = ((BaseTree)tree.Children[0]).Text };

			var node = tree.GetChild(1).GetChild(0);
			variable.Value = node.Text;

			return variable;
		}
	}
}