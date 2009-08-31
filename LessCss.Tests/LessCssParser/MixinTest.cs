using NUnit.Framework;

namespace LessCss.Tests.LessCssParser
{
	[TestFixture]
	public class MixinTest
	{
		[Test]
		public void Parser_SimpleMixin_CorrectAST()
		{
			var result = "a;".GetStringTree(p => p.mixin());

			result.Should().Be.EqualTo("MIXIN (SELECTOR (TAG a))");
		}
	}
}
