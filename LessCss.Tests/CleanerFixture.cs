namespace LessCss.Tests
{
    using System;
    using System.IO;
    using NUnit.Framework;
    using Preprocessor;

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
        public void ExtendedTest()
        {
            string input =
                @"@a: 2;
@x: @a * @a;
@y: @x + 1;
@z: @x * 2 + @y;

.variables {
  width: @z + 1cm; // 14cm
}

@b: @a * 10;
@c: #888;
@fonts: ""Trebuchet MS"", Verdana, sans-serif;

.variables {
  height: @b + @x + 0px; // 24px
  color: @c;
  font-family: @fonts;
}";
            string desiredOutput =
                @"@a:2;@x:@a*@a;@y:@x+1;@z:@x*2+@y;.variables{width:@z+1cm;}@b:@a*10;@c:#888;@fonts:""Trebuchet MS"", Verdana, sans-serif;.variables{height:@b+@x+0px;color:@c;font-family:@fonts;}";
            var preprocessor = new Processor(input);
            char[] output = preprocessor.Output;
            Console.WriteLine(output);

            Assert.AreEqual(desiredOutput, output);
        }
    }
}