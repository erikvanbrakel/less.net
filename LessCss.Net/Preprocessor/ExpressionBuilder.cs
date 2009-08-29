namespace LessCss.Preprocessor
{
    using System.Text;

    public class ExpressionBuilder : IExpressionBuilder
    {
        public IExpression BuildExpression(char[] input)
        {
            var builder = new StringBuilder();
            builder.Append(input);
            var expressionText = builder.ToString();

            string[] sub = expressionText.Split(':');
            return new StyleExpression(sub[0].Trim(), sub[1].Trim());
        }
    }
}