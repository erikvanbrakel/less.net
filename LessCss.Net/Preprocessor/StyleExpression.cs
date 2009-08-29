namespace LessCss.Preprocessor
{
    using System.Collections.Generic;

    public class StyleExpression : IExpression
    {
        public StyleExpression(string key, string value) : this(new KeyValuePair<string, string>(key, value))
        {
        }

        public StyleExpression(KeyValuePair<string, string> value)
        {
            Expression = value;
        }

        public KeyValuePair<string, string> Expression
        {
            get; private set;
        }
    }
}