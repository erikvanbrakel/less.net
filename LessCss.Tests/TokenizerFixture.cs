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
            ITreeNode tree = BuildTree(input);;

            Assert.AreEqual(1, tree.Expressions.Count());
        }

        [Test]
        public void AppendsSubNodesToCurrentLevel()
        {
            var input = ".a { background: black; }";
            ITreeNode tree = BuildTree(input);;

            Assert.AreEqual(1, tree.Children.Count());
        }

        [Test]
        public void CanHandleMultipleChildrenOnOneLevel()
        {
            var input = ".a { background: black; } .b {b:black;}";

            ITreeNode tree = BuildTree(input);;
            Assert.AreEqual(2, tree.Children.Count());
        }

        [Test]
        public void CanHandleMultipleExpressionsOnOneLevel()
        {
            var input = "@y: @x + 1;@z: @x * 2 + @y;";

            ITreeNode tree = BuildTree(input);;
            Assert.AreEqual(2, tree.Expressions.Count());
        }

        [Test]
        public void CanHandleNestedChildren()
        {
            var input = "#namespace { .borders { border-style: dotted; } }";
            ITreeNode tree = BuildTree(input);

            Assert.AreEqual(1, tree.Children.Count());
            Assert.AreEqual(1, tree.Children.First().Children.Count());
        }

        [Test]
        public void CanHandleNestedChildExpressions()
        {
            var input = "#namespace { .borders { border-style: dotted; } }";
            ITreeNode tree = BuildTree(input);

            Assert.AreEqual(1, tree
                .Children.First()
                    .Children.First().Expressions.Count());
        }

        [Test]
        public void RootNodeIsCalledROOT()
        {
            var input = "";
            ITreeNode tree = BuildTree(input);

            Assert.AreEqual("ROOT", tree.Descriptor);
        }

        [Test]
        public void NestedChildNodeDescriptorMatchesCSSDescriptor()
        {
            var input = ".a { .b { x:b; } }";
            ITreeNode tree = BuildTree(input);

            Assert.AreEqual(".b", tree
                .Children.First()
                    .Children.First().Descriptor);
        }

        [Test]
        public void CanHandleBracesInStrings()
        {
            var input = ".a { background: \"{\"; }";
            ITreeNode tree = BuildTree(input);

            Assert.AreEqual("\"{\"", tree
                .Children.First()
                    .Expressions.First()
                        .Expression.Value);
        }

        [Test]
        public void CanHandleSingleQuoteStrings()
        {
            var input = "background: '{';";
            ITreeNode tree = BuildTree(input);

            Assert.AreEqual("'{'", tree.Expressions.First()
                .Expression.Value);
        }

        [Test]
        public void CanHandleComplexStrings()
        {
            var input = "content: \"#*%:&^,)!.(~*})\";";
            ITreeNode tree = BuildTree(input);

            Assert.AreEqual("\"#*%:&^,)!.(~*})\"", tree.Expressions.First().Expression.Value);
        }

        private ITreeNode BuildTree(string input)
        {
            var tokenizer = new Tokenizer();
            return tokenizer.BuildTree(input);;
        }
    }
}