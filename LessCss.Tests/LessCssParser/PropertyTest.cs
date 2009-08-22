using NUnit.Framework;

namespace LessCss.Tests.LessCssParser
{
	[TestFixture]
	public class PropertyTest
	{
		[Test]
		public void Parser_SimpleProperty_CorrectAST()
		{
			var result = "color: red;"
				.GetTree(p => p.property())
				.ToStringTree();

			result.Should().Be.EqualTo("(PROPERTY color red)");
		}

		[Test]
		public void Parser_ShorthandProperty_CorrectAST()
		{
			var result = "border: 1px solid #fff"
				.GetTree(p => p.property())
				.ToStringTree();

			result.Should().Be.EqualTo("(PROPERTY border (EXPR (CONSTANT 1 px)) solid (EXPR (CONSTANT #fff)))");
		}
	}
}
