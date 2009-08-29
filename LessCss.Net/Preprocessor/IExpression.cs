namespace LessCss.Preprocessor
{
    using System.Collections.Generic;

    public interface IExpression
    {
        KeyValuePair<string, string> Expression { get; }
    }
}