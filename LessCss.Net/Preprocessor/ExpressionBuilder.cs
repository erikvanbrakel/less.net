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
            foreach (char c in input)
            {
                if (!completedDescriptor && c == ':')
                {
                    completedDescriptor = true;
                    descriptor = builder.ToString();
                    builder = new StringBuilder();
                    continue;
                }
                builder.Append(c);
            }
            
            var value = builder.ToString();

            return new StyleExpression(descriptor.Trim(), value.Trim());
        }
    }
}