namespace LessCss.Tests
{
    using System.Linq;
    using NUnit.Framework;
    using Preprocessor;

    [TestFixture]
    public class TokenizerFixture
    {
        [Test]
        public void AppendsExpressionToCurrentLevel()
        {
            var input = "background: black;";
            ITreeLevel tree = BuildTree(input);;

            Assert.AreEqual(1, tree.Expressions.Count());
        }

        [Test]
        public void AppendsSubNodesToCurrentLevel()
        {
            var input = ".a { background: black; }";
            ITreeLevel tree = BuildTree(input);;

            Assert.AreEqual(1, tree.Children.Count());
        }

        [Test]
        public void CanHandleMultipleChildrenOnOneLevel()
        {
            var input = ".a { background: black; } .b {b:black;}";

            ITreeLevel tree = BuildTree(input);;
            Assert.AreEqual(2, tree.Children.Count());
        }

        [Test]
        public void CanHandleMultipleExpressionsOnOneLevel()
        {
            var input = "@y: @x + 1;@z: @x * 2 + @y;";

            ITreeLevel tree = BuildTree(input);;
            Assert.AreEqual(2, tree.Expressions.Count());
        }

        [Test]
        public void CanHandleNestedChildren()
        {
            var input = "#namespace { .borders { border-style: dotted; } }";
            ITreeLevel tree = BuildTree(input);

            Assert.AreEqual(1, tree.Children.Count());
            Assert.AreEqual(1, tree.Children.First().Children.Count());
        }

        private ITreeLevel BuildTree(string input)
        {
            var tokenizer = new Tokenizer();
            return tokenizer.BuildTree(input);;
        }
    }
}