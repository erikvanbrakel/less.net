namespace LessCss.Preprocessor
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Tokenizer
    {
        private IExpressionBuilder expressionBuilder = new ExpressionBuilder();

        public IExpressionBuilder ExpressionBuilder
        {
            get { return expressionBuilder; }
            set { expressionBuilder = value; }
        }

        public ITreeLevel BuildTree(string input)
        {
            ITreeLevel currentLevel = new TreeLevel("ROOT", null);
            char[] array = input.ToCharArray();

            IList<char> buffer = new List<char>();
            foreach(char c in array)
            {
                if (c == '{')
                {
                    var builder = new StringBuilder();
                    builder.Append(buffer);
                    var childLevel = new TreeLevel(builder.ToString(), currentLevel);
                    currentLevel.AppendChild(childLevel);
                    buffer = new List<char>();
                    currentLevel = childLevel;
                }
                if (c == ';')
                {
                    currentLevel.AppendExpression(ExpressionBuilder.BuildExpression(buffer.ToArray()));
                    buffer = new List<char>();
                }
                if (c == '}')
                {
                    currentLevel = currentLevel.Parent;
                }
                buffer.Add(c);
            }

            return currentLevel;
        }
    }

    public interface IExpressionBuilder
    {
        IExpression BuildExpression(char[] input);
    }

    public class ExpressionBuilder : IExpressionBuilder
    {
        public ExpressionBuilder()
        {
            
        }

        public IExpression BuildExpression(char[] input)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(input);
            string s = builder.ToString();

            string[] strings = s.Split(':');
            return new StyleExpression(strings[0], strings[1]);
        }
}
}