namespace LessCss.Preprocessor
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Tokenizer
    {
        private IExpressionBuilder expressionBuilder = new ExpressionBuilder();
        private IDescriptorBuilder descriptorBuilder = new DescriptorBuilder();
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
            foreach (char c in array)
            {
                switch (c)
                {
                    case '{':
                        string descriptor = descriptorBuilder.BuildDescriptor(buffer.ToArray());
                        
                        var childLevel = new TreeLevel(descriptor, currentLevel);
                        currentLevel.AppendChild(childLevel);
                        buffer = new List<char>();
                        currentLevel = childLevel;
                        break;
                    case ';':
                        currentLevel.AppendExpression(ExpressionBuilder.BuildExpression(buffer.ToArray()));
                        buffer = new List<char>();
                        break;
                    case '}':
                        currentLevel = currentLevel.Parent;
                        break;
                    default:
                        buffer.Add(c);
                        break;
                }
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