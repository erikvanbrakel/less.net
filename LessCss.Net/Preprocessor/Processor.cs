/*
 * Copyright 2009 Less.Net
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *  http://www.apache.org/licenses/LICENSE-2.0
 *  
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

namespace LessCss.Preprocessor
{
    public class Processor
    {
        private string input;
        private readonly char[] output;

        public Processor(string input)
        {
            this.input = input;
            output = CleanStream().ToCharArray();
        }

        private string CleanStream()
        {
            input = WhiteSpaceFilter.ConvertToUnix(input);
            input = WhiteSpaceFilter.RemoveComments(input);
            input = WhiteSpaceFilter.RemoveMultipleWhiteSpaces(input);
            input = WhiteSpaceFilter.RemoveLeadingAndTrailingWhiteSpace(input);
            input = WhiteSpaceFilter.RemoveNewLines(input);
            input = WhiteSpaceFilter.RemoveExtendedComments(input);
            var tokenizer = new Tokenizer();
            ITreeNode tree = tokenizer.BuildTree(input);
            var compiler = new TreeCompiler();
            input = compiler.CompileTree(tree);
            return input;
        }

        public char[] Output
        {
            get { return output; }
        }
    }
}