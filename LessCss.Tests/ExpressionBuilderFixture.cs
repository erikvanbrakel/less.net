namespace LessCss.Tests
{
    using NUnit.Framework;
    using Preprocessor;

    [TestFixture]
    public class ExpressionBuilderFixture
    {
        [Test]
        public void CorrectlyIdentifiesFirstColonAsSplitter()
        {
            var input = "a:b:c";
            var builder = new ExpressionBuilder();
            IExpression expression = builder.BuildExpression(input.ToCharArray());
            Assert.AreEqual(expression.Expression.Key, "a");
            Assert.AreEqual(expression.Expression.Value, "b:c");
        }
    }
}