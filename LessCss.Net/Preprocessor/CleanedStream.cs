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

        public static string RemoveWhitespaces(string input)
        {
            var searcher = new WhitespaceSearcher(input);
            return searcher.Execute();
        }

        private class WhitespaceSearcher
        {
            StringBuilder sb = new StringBuilder();
            private readonly string input;
            

            public WhitespaceSearcher(string input)
            {
                this.input = input;
            }

            public string Execute()
            {
                SplitChunks();
                return sb.ToString();
            }

            public void SplitChunks()
            {
                int currentIndex = 0;
                while (currentIndex < input.Length)
                {
                    int nextSemicolon = FindNextSemicolonIndex(currentIndex);
                    int nextOpeningBrace = FindNextOpeningBrace(currentIndex);
                    if ((nextOpeningBrace != -1) && (nextOpeningBrace < nextSemicolon))
                    {
                        //Brace block ahead
                        int nextClosingBrace = FindNextClosingBrace(currentIndex);
                        var textBeforeBrace = input.Substring(currentIndex, nextOpeningBrace - currentIndex);
                        var braceContent = input.Substring(nextOpeningBrace + 1, nextClosingBrace - nextOpeningBrace - 1);
                        sb.Append(RemoveLeadingAndTrailingWhiteSpace(textBeforeBrace));
                        sb.Append("{");
                        CleanBraceContent(braceContent);
                        sb.Append("}");
                        currentIndex = nextClosingBrace + 1;
                    }
                    else if (nextSemicolon != -1)
                    {
                        //Variable block (.a = 1;)
                        int length = nextSemicolon - currentIndex;
                        string declaration = input.Substring(currentIndex, length);
                        FormatDeclaration(declaration);
                        currentIndex = nextSemicolon + 1;
                    }
                }
            }

            private void CleanBraceContent(string content)
            {
                var declarations = content.Split(';');
                foreach (string declaration in declarations)
                {
                    FormatDeclaration(declaration);
                }
                
            }

            private void FormatDeclaration(string declaration)
            {
                if (declaration.Length == 0) return;
                declaration = RemoveLeadingAndTrailingWhiteSpace(declaration);
                declaration = CreateRegex(" *: *").Replace(declaration, ":");
                declaration = CreateRegex(" *\\* *").Replace(declaration, "*");
                declaration = CreateRegex(" *= *").Replace(declaration, "=");
                declaration = CreateRegex(" */ *").Replace(declaration, "/");
                declaration = CreateRegex(" *- *").Replace(declaration, "-");
                declaration = CreateRegex(" *\\+ *").Replace(declaration, "+");
                sb.Append(declaration);
                sb.Append(";");
            }

            private int FindNextSemicolonIndex(int startIndex)
            {
                return input.IndexOf(';', startIndex);
            }
            private int FindNextOpeningBrace(int startIndex)
            {
                return input.IndexOf('{', startIndex);
            }
            private int FindNextClosingBrace(int startIndex)
            {
                return input.IndexOf('}', startIndex);
            }
        }
    }
}