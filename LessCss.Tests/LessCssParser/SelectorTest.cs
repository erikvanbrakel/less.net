using NUnit.Framework;

namespace LessCss.Tests.LessCssParser
{
	[TestFixture]
	public class SelectorTest
	{
		[Test]
		public void Parser_SimpleSelector_CorrectAST()
		{
			var result = "body"
				.GetTree(p => p.selectors())
				.ToStringTree();

			result.Should().Be.EqualTo("(SELECTOR (TAG body))");
		}

		[Test]
		public void Parser_CompoundSelectorGroups_CorrectAST()
		{
			var result = "body .a #id, .class #id span"
				.GetTree(p => p.selectors())
				.ToStringTree();

			result.Should().Be.EqualTo("(SELECTOR (TAG body) (CLASS a) (ID id)) (SELECTOR (CLASS class) (ID id) (TAG span))");
		}

		[Test]
		public void Parser_CompoundSelector_CorrectAST()
		{
			var result = "body .a #id"
				.GetTree(p => p.selectors())
				.ToStringTree();

			result.Should().Be.EqualTo("(SELECTOR (TAG body) (CLASS a) (ID id))");
		}
	}
}