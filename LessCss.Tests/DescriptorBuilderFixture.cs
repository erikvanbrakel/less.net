namespace LessCss.Tests
{
    using NUnit.Framework;
    using Preprocessor;

    [TestFixture]
    public class DescriptorBuilderFixture
    {
        [Test]
        public void DescriptorBuilderTrimsWhiteSpaces()
        {
            var input = ".a ";
            string descriptor = BuildDescription(input);

            Assert.AreEqual(".a", descriptor);
        }

        private string BuildDescription(string input)
        {
            return new DescriptorBuilder().BuildDescriptor(input.ToCharArray());
        }
    }
}