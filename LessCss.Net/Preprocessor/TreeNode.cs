namespace LessCss.Preprocessor
{
    using System.Collections.Generic;

    public class TreeNode : ITreeNode
    {
        public TreeNode(string descriptor, ITreeNode parent)
        {
            Descriptor = descriptor;
            Parent = parent;
        }
        private IList<IExpression> expressions = new List<IExpression>();
        private IList<ITreeNode> children = new List<ITreeNode>();

        public IEnumerable<ITreeNode> Children
        {
            get { return children; }
        }

        public IEnumerable<IExpression> Expressions
        {
            get { return expressions; }
        }

        public ITreeNode Parent { get; private set; }

        public string Descriptor { get; private set; }

        public void AppendExpression(IExpression expression)
        {
            expressions.Add(expression);
        }

        public void AppendChild(ITreeNode child)
        {
            children.Add(child);
        }
    }
}