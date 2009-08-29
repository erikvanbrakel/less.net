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
            IExpression expression = BuildExpression(input);
            Assert.AreEqual(expression.Expression.Key, "a");
            Assert.AreEqual(expression.Expression.Value, "b:c");
        }

        [Test]
        public void RemovesUnnecessaryWhitespacesInValue()
        {
            var input = "@a:  1 + 3;";
            var expression = BuildExpression(input);

            Assert.AreEqual("1+3;", expression.Expression.Value);
        }

        [Test]
        public void LeavesStringsIntact()
        {
            var input = "hover: \"a b\"";
            var expression = BuildExpression(input);

            Assert.AreEqual("\"a b\"", expression.Expression.Value);
        }

        [Test]
        public void ContinuesWhiteSpaceRemovalAfterString()
        {
            var input = "hover: \"a b\" + 3;";
            var expression = BuildExpression(input);

            Assert.AreEqual("\"a b\"+3;", expression.Expression.Value);
        }

        [Test]
        public void CanHandleSingleQuotationMarkString()
        {
            var input = "hover: 'a b' + 3;";
            var expression = BuildExpression(input);

            Assert.AreEqual("'a b'+3;", expression.Expression.Value);
        }

        private IExpression BuildExpression(string input)
        {
            return new ExpressionBuilder().BuildExpression(input.ToCharArray());
        }
    }
}