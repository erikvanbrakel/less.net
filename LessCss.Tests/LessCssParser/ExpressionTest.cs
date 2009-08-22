using NUnit.Framework;

namespace LessCss.Tests.LessCssParser
{
	[TestFixture]
	public class ExpressionTest
	{
		[Test]
		public void Parser_SimpleExpression_CorrectAST()
		{
			var addition = "4 + 2"
				.GetTree(p => p.expression())
				.ToStringTree();

			var multiplication = "4 * 2"
				.GetTree(p => p.expression())
				.ToStringTree();

			var subtraction = "4 - 2"
				.GetTree(p => p.expression())
				.ToStringTree();

			var division = "4 / 2"
				.GetTree(p => p.expression())
				.ToStringTree();

			addition.Should().Be.EqualTo("(EXPR (+ (CONSTANT 4) (CONSTANT 2)))");
			multiplication.Should().Be.EqualTo("(EXPR (* (CONSTANT 4) (CONSTANT 2)))");
			subtraction.Should().Be.EqualTo("(EXPR (- (CONSTANT 4) (CONSTANT 2)))");
			division.Should().Be.EqualTo("(EXPR (/ (CONSTANT 4) (CONSTANT 2)))");
		}

		[Test]
		public void Parser_CompoundExpression_CorrectAST()
		{
			var expression = "4 + 2 * 5 + 10 / (11 + 3)"
				.GetTree(p => p.expression())
				.ToStringTree();

			expression.Should().Be.EqualTo("(EXPR (+ (+ (CONSTANT 4) (* (CONSTANT 2) (CONSTANT 5))) (/ (CONSTANT 10) (+ (CONSTANT 11) (CONSTANT 3)))))");
		}
	}
}
