namespace LessCss.Tests
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class CleanerFixture
    {
        public const string css =
@"#sidebar h1 ul li
{
  height : 100px ; // 24px
  color: #fffff ;
  font-family: @fonts;
}";


        [Test]
        public void CanTrimLeadingWhiteSpaces()
        {
            string input = "  color: #fffff;";
            string desiredOutput = "color: #fffff;";

            string output = WhiteSpaceFilter.RemoveLeadingAndTrailingWhiteSpace(input);
            Console.WriteLine(output);
            Assert.AreEqual(desiredOutput, output);
        }

        [Test]
        public void CanTrimTrailingWhiteSpaces()
        {
            string input = "color: #ffff;  ";
            string desiredOutput = "color: #ffff;";

            string output = WhiteSpaceFilter.RemoveLeadingAndTrailingWhiteSpace(input);
            Console.WriteLine(output);
            Assert.AreEqual(desiredOutput, output);
        }

        [Test]
        public void CanTrimEndOfLineComment()
        {
            string desiredOutput = WhiteSpaceFilter.ConvertToUnix(
@"#sidebar h1 ul li
{
  height : 100px ; 
  color: #fffff ;
  font-family: @fonts;
}");
            string unix = WhiteSpaceFilter.ConvertToUnix(css);


            string output = WhiteSpaceFilter.RemoveComments(unix);
            Console.WriteLine(output);
            Assert.AreEqual(desiredOutput, output);
        }

        [Test]
        public void CanRemoveMultilineComment()
        {
            string input =
@"#sidebar h1 ul li
{
  /*height : 100px ; 
  color: #fffff ;*/
  font-family: @fonts;
}";
            string desiredOutput = 
@"#sidebar h1 ul li
{
  
  font-family: @fonts;
}";
            string output = WhiteSpaceFilter.RemoveMultiLineComments(input);
            Console.WriteLine(output);
            Assert.AreEqual(desiredOutput, output);
        }
        
    }
}