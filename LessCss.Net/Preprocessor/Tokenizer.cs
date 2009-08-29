namespace LessCss.Preprocessor
{
    using System.Collections.Generic;
    using System.Linq;

    public class Tokenizer
    {
        private IExpressionBuilder expressionBuilder = new ExpressionBuilder();
        private IDescriptorBuilder descriptorBuilder = new DescriptorBuilder();

        public IExpressionBuilder ExpressionBuilder
        {
            get { return expressionBuilder; }
            set { expressionBuilder = value; }
        }

        public IDescriptorBuilder DescriptorBuilder
        {
            get { return descriptorBuilder; }
            set { descriptorBuilder = value; }
        }

        public ITreeLevel BuildTree(string input)
        {
            ITreeLevel currentLevel = new TreeLevel("ROOT", null);
            char[] array = input.ToCharArray();

            IList<char> buffer = new List<char>();
            bool escaped = false;
            char escapeCharacter = '0';
            foreach (char c in array)
            {
                if (escaped)
                {
                    buffer.Add(c);
                    escaped = (c != escapeCharacter);
                    continue;
                }

                switch (c)
                {
                    case '{':
                        string descriptor = DescriptorBuilder.BuildDescriptor(buffer.ToArray());
                            
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
                    case '"':
                        buffer.Add(c);
                        escapeCharacter = '"';
                        escaped = true;
                        break;
                    case '\'':
                        buffer.Add(c);
                        escaped = true;
                        escapeCharacter = '\'';
                        break;
                    default:
                        buffer.Add(c);
                        break;
                }
            }

            return currentLevel;
        }
    }
}