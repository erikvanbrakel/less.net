namespace LessCss.Preprocessor
{
    using System.Text;

    public class ExpressionBuilder : IExpressionBuilder
    {
        public IExpression BuildExpression(char[] input)
        {
            var builder = new StringBuilder();
            bool completedDescriptor = false;
            string descriptor = null;
            bool escaped = false;
            char escapeChar = '0';
            foreach (char c in input)
            {
                if (!completedDescriptor && c == ':')
                {
                    completedDescriptor = true;
                    descriptor = builder.ToString();
                    builder = new StringBuilder();
                    continue;
                }
                if (escaped)
                {
                    builder.Append(c);
                    escaped = (escapeChar != c);
                }
                else
                {
                    if (c == '\'' || c == '"')
                    {
                        escaped = true;
                        escapeChar = c;
                    }
                    if (c != ' ')
                        builder.Append(c);
                }
            }
            
            var value = builder.ToString();

            return new StyleExpression(descriptor.Trim(), value.Trim());
        }
    }
}