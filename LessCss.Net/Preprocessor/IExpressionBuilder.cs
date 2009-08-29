namespace LessCss.Preprocessor
{
    public interface IExpressionBuilder
    {
        IExpression BuildExpression(char[] input);
    }
}