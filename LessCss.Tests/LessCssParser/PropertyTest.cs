using NUnit.Framework;

namespace LessCss.Tests.LessCssParser
{
	[TestFixture]
	public class PropertyTest
	{
		[Test]
		public void Parser_SimpleProperty_CorrectAST()
		{
			var result = "color: red;".GetStringTree(p => p.property());

			result.Should().Be.EqualTo("(PROPERTY color red)");
		}

		[Test]
		public void Parser_ShorthandProperty_CorrectAST()
		{
			var result = "border: 1px solid #fff".GetStringTree(p => p.property());

			result.Should().Be.EqualTo("(PROPERTY border (EXPR (CONSTANT 1 px)) solid (EXPR (CONSTANT #fff)))");
		}
	}
}
