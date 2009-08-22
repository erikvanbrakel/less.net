using System;
using Antlr.Runtime;
using Antlr.Runtime.Tree;

namespace LessCss.Tests.LessCssParser
{
	internal static class ParserHelper
	{
		public static ITree GetTree(this string input, Func<lesscssParser, ParserRuleReturnScope> func)
		{
			var parser = CreateParser(input);
			return func(parser).Tree as ITree;
		}

		private static lesscssParser CreateParser(string input)
		{
			var stream = new ANTLRStringStream(input);
			var lexer = new lesscssLexer(stream);
			return new lesscssParser(new CommonTokenStream(lexer));
		}

	}
}