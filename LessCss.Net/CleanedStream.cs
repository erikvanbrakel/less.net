namespace LessCss
{
    using System;
    using System.IO;
    using System.Text.RegularExpressions;

    public class WhiteSpaceFilter
    {
        private static Regex CreateRegex(string pattern)
        {
            return new Regex(pattern, RegexOptions.Multiline);
        }
        public static string RemoveLeadingAndTrailingWhiteSpace(string input)
        {
            //Leading Whitespace: ^\s+
            //Trailing Whitespace: \s+$
            var regex = CreateRegex(@"^\s+|\s+$");
            return regex.Replace(input, "");
        }

        public static string ConvertToUnix(string input)
        {
            return CreateRegex(@"\r").Replace(input, "");
        }

        public static string RemoveComments(string input)
        {
            Regex regex = CreateRegex("//(.)*$");
            return regex.Replace(input, "");
        }

        public static string RemoveMultiLineComments(string input)
        {
            return CreateRegex(@"/\*(.|\n)*\*/").Replace(input, "");
        }
    }

    public class Cleaner
    {
        private readonly StreamReader reader;
        private readonly string output;
        public Cleaner(StreamReader reader)
        {
            this.reader = reader;
            output = CleanStream();
        }

        private string CleanStream()
        {
            string input = reader.ReadToEnd();
            input = WhiteSpaceFilter.ConvertToUnix(input);
            input = WhiteSpaceFilter.RemoveComments(input);
            input = WhiteSpaceFilter.RemoveLeadingAndTrailingWhiteSpace(input);
            input = WhiteSpaceFilter.RemoveMultiLineComments(input);

            return input;
        }

        public char[] Output
        {
            get
            {
                return output.ToCharArray();
            }
        }
    }
}