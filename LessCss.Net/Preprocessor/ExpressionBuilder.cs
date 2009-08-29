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
    using System.Text;

    public class ExpressionBuilder : IExpressionBuilder
    {
        public IExpression BuildExpression(char[] input)
        {
            var builder = new StringBuilder();
            bool completedDescriptor = false;
            string descriptor = null;
            bool escaped = false;
            char escapeChar = '0';
            foreach (char c in input)
            {
                if (!completedDescriptor && c == ':')
                {
                    completedDescriptor = true;
                    descriptor = builder.ToString();
                    builder = new StringBuilder();
                    continue;
                }
                if (escaped)
                {
                    builder.Append(c);
                    escaped = (escapeChar != c);
                }
                else
                {
                    if (c == '\'' || c == '"')
                    {
                        escaped = true;
                        escapeChar = c;
                    }
                    if (c != ' ')
                        builder.Append(c);
                }
            }
            
            var value = builder.ToString();

            return new StyleExpression(descriptor.Trim(), value.Trim());
        }
    }
}