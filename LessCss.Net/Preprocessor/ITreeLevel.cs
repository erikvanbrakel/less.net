namespace LessCss.Preprocessor
{
    using System;
    using System.Collections.Generic;

    public interface ITreeLevel
    {
        IEnumerable<ITreeLevel> Children { get; }
        IEnumerable<IExpression> Expressions { get; }
        ITreeLevel Parent { get; }

        void AppendExpression(IExpression expression);
        void AppendChild(ITreeLevel child);
        string Descriptor { get; }
    }

    public class TreeLevel : ITreeLevel
    {
        public TreeLevel(string descriptor, ITreeLevel parent)
        {
            Descriptor = descriptor;
            Parent = parent;
        }
        private IList<IExpression> expressions = new List<IExpression>();
        private IList<ITreeLevel> children = new List<ITreeLevel>();

        public IEnumerable<ITreeLevel> Children
        {
            get { return children; }
        }

        public IEnumerable<IExpression> Expressions
        {
            get { return expressions; }
        }

        public ITreeLevel Parent { get; private set; }

        public string Descriptor { get; private set; }

        public void AppendExpression(IExpression expression)
        {
            expressions.Add(expression);
        }

        public void AppendChild(ITreeLevel child)
        {
            children.Add(child);
        }
    }
}