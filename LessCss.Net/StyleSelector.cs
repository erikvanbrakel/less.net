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
 * File: StyleSelector.cs
 */
using Antlr.Runtime.Tree;
using System.Linq;

namespace LessCss
{
	public class StyleSelector
	{
		public string Name { get; set; }

		public string ToCss()
		{
			return Name;
		}

		public bool Equals(StyleSelector obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			return Equals(obj.Name, Name);
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			if (obj.GetType() != typeof (StyleSelector)) return false;
			return Equals((StyleSelector) obj);
		}

		public override int GetHashCode()
		{
			return Name.GetHashCode();
		}
	}
}