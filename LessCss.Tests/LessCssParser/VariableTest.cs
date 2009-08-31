using NUnit.Framework;

namespace LessCss.Tests.LessCssParser
{
	[TestFixture]
	public class VariableTest
	{
		[Test]
		public void Parser_Variable_CorrectAST()
		{
			var result = "@varname:11".GetStringTree(p => p.variable());

			result.Should().Be.EqualTo("(VAR varname (EXPR (CONSTANT 11)))");
		}
	}
}
