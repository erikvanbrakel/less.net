namespace LessCss.Preprocessor
{
    public interface ITreeCompiler
    {
        string CompileTree(ITreeNode rootNode);
    }
}