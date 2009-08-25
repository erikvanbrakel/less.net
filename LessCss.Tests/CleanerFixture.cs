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
        public void CanRemoveExtendedComment()
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
            string output = WhiteSpaceFilter.RemoveExtendedComments(input);
            Console.WriteLine(output);
            Assert.AreEqual(desiredOutput, output);
        }

        [Test]
        public void RemoveExtendedCommentIgnoresEscapedComment()
        {
            string input = "font-family: \"/*test*/\"";
            string desiredOutput = "font-family: \"/*test*/\"";

            var output = WhiteSpaceFilter.RemoveExtendedComments(input);
            Console.WriteLine(output);

            Assert.AreEqual(desiredOutput, output);
        }
        
        [Test]
        public void CanRemoveNewlines()
        {
            string output = WhiteSpaceFilter.RemoveNewLines(css);
            Console.WriteLine(output);
            string[] lines = output.Split(Environment.NewLine.ToCharArray());

            Assert.AreEqual(1, lines.Length);
        }

        [Test]
        public void CanRemoveMultipleWhitespaces()
        {
            string input = "whi   te   space";
            string desiredOutput = "whi te space";

            string output = WhiteSpaceFilter.RemoveMultipleWhiteSpaces(input);
            Assert.AreEqual(desiredOutput, output);
        }

        [Test]
        public void CanRemoveUnnecessaryWhitespacesWithinBraces()
        {
            string input = WhiteSpaceFilter.RemoveNewLines(
@"#sidebar h1 ul li
{
height : 100px ;
color: #fffff ;
font-family: @fonts;
}");
            string desiredOutput = WhiteSpaceFilter.RemoveNewLines(
@"#sidebar h1 ul li
{
height:100px;
color:#fffff;
font-family:@fonts;
}");
            Console.WriteLine(input);
            var output = WhiteSpaceFilter.RemoveWhitespaces(input);
            Console.WriteLine(output);
            
            Assert.AreEqual(desiredOutput, output);
        }

        [Test]
        public void CanRemoveUnnecessaryWhitespacesFromVariableDeclarations()
        {
            string input = ".a = 3 ;";
            string desiredOutput = ".a=3;";

            var output = WhiteSpaceFilter.RemoveWhitespaces(input);
            Console.WriteLine(output);
            Assert.AreEqual(desiredOutput, output);
        }

        [Test]
        public void CanRemoveUnnecessaryWhitespacesFromComplexVariables()
        {
            string input = WhiteSpaceFilter.RemoveNewLines(
@".variables {
height: @b + @x + 0px;
color: @c;
font-family: @fonts;
}");
            string desiredOutput = ".variables{height:@b+@x+0px;color:@c;font-family:@fonts;}";
            Console.WriteLine(input);
            var output = WhiteSpaceFilter.RemoveWhitespaces(input);
            Console.WriteLine(output);
            Assert.AreEqual(desiredOutput, output);
        }
    }
}