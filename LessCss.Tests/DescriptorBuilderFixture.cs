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
            var builder = new DescriptorBuilder();
            string descriptor = builder.BuildDescriptor(input.ToCharArray());

            Assert.AreEqual(".a", descriptor);
        }
    }
}