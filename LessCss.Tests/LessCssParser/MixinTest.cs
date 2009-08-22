using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace LessCss.Tests.LessCssParser
{
	[TestFixture]
	public class MixinTest
	{
		[Test]
		public void Parser_SimpleMixin_CorrectAST()
		{
			var result = "a;"
				.GetTree(p => p.mixin())
				.ToStringTree();

			result.Should().Be.EqualTo("MIXIN (SELECTOR (TAG a))");
		}
	}
}
