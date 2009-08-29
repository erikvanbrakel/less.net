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

        public ITreeNode BuildTree(string input)
        {
            ITreeNode currentNode = new TreeNode("ROOT", null);
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
                            
                        var childLevel = new TreeNode(descriptor, currentNode);
                        currentNode.AppendChild(childLevel);
                        buffer = new List<char>();
                        currentNode = childLevel;
                        break;
                    case ';':
                        currentNode.AppendExpression(ExpressionBuilder.BuildExpression(buffer.ToArray()));
                        buffer = new List<char>();
                        break;
                    case '}':
                        currentNode = currentNode.Parent;
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

            return currentNode;
        }
    }
}