namespace LessCss.Preprocessor
{
    public class Processor
    {
        private string input;
        private readonly char[] output;

        public Processor(string input)
        {
            this.input = input;
            output = CleanStream().ToCharArray();
        }

        private string CleanStream()
        {
            input = WhiteSpaceFilter.ConvertToUnix(input);
            input = WhiteSpaceFilter.RemoveComments(input);
            input = WhiteSpaceFilter.RemoveMultipleWhiteSpaces(input);
            input = WhiteSpaceFilter.RemoveLeadingAndTrailingWhiteSpace(input);
            input = WhiteSpaceFilter.RemoveNewLines(input);
            input = WhiteSpaceFilter.RemoveExtendedComments(input);
            input = WhiteSpaceFilter.RemoveWhitespaces(input);

            return input;
        }

        public char[] Output
        {
            get { return output; }
        }
    }
}