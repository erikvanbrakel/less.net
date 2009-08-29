namespace LessCss.Preprocessor
{
    using System.Collections.Generic;

    public interface ITreeNode
    {
        IEnumerable<ITreeNode> Children { get; }
        IEnumerable<IExpression> Expressions { get; }
        ITreeNode Parent { get; }

        void AppendExpression(IExpression expression);
        void AppendChild(ITreeNode child);
        string Descriptor { get; }
    }
}