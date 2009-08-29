namespace LessCss.Preprocessor
{
    public interface ITokenizer
    {
        ITreeNode BuildTree(string input);
    }
}