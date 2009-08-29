namespace LessCss.Preprocessor
{
    using System;
    using System.IO;
    using System.Text;
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

        public static string RemoveExtendedComments(string input)
        {
            // Clear Regex: (?<!\".*)/\*(.|\n)*\*/(?!.*\")
            return CreateRegex("(?<!\\\".*)/\\*(.|\\n)*\\*/(?!.*\\\")").Replace(input, "");
        }

        public static string RemoveMultipleWhiteSpaces(string input)
        {
            return CreateRegex(" {2,}").Replace(input, " ");
        }

        public static string RemoveNewLines(string input)
        {
            return CreateRegex(@"\r?\n?").Replace(input, "");
        }
    }
}