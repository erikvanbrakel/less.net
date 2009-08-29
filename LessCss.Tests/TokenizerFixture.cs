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
            var tokenizer = new Tokenizer();
            ITreeLevel level = tokenizer.BuildTree(input);

            Assert.AreEqual(1, level.Expressions.Count());
        }
    }
}