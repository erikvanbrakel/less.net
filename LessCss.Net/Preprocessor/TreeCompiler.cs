namespace LessCss.Preprocessor
{
    using System.Text;

    public class TreeCompiler
    {
        public string CompileTree(ITreeNode rootNode)
        {
            StringBuilder builder = new StringBuilder();
            Compile(rootNode, builder);
            return builder.ToString();
        }

        private void Compile(ITreeNode node, StringBuilder builder)
        {
            if (node.Descriptor != "ROOT")
            {
                builder.Append(node.Descriptor);
                builder.Append('{');
            }
            foreach(var child in node.Children)
            {
                Compile(child, builder);
            }

            foreach(var expression in node.Expressions)
            {
                builder.Append(expression.Expression.Key);
                builder.Append(':');
                builder.Append(expression.Expression.Value);
                builder.Append(';');
            }

            if (node.Descriptor != "ROOT")
            {
                builder.Append('}');
            }
        }
    }
}