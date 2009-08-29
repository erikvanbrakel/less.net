namespace LessCss.Preprocessor
{
    using System;

    public class Tokenizer
    {
        public ITreeLevel BuildTree(string input)
        {
            var currentLevel = new TreeLevel("ROOT");
            //todo: find next { and add all items before that to the Expressions. After that switch level and repeat
            throw new NotImplementedException();
        }
    }
}