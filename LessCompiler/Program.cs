using System;
using LessCss;

namespace LessCompiler
{
	class Program
	{
		static void Main(string[] args)
		{
			var testcase = "operations";
			var less = getLess(testcase).Evaluate().Flatten().Mixin().Merge();
			var css = getCss(testcase).Evaluate().Flatten().Merge();

			Console.WriteLine(less.ToCss());
			//Console.WriteLine(css.ToCss());
			Console.WriteLine(less.Equals(css));
			Console.ReadKey();
		}

		private static StyleDocument getLess(string s)
		{
			return StyleDocument.FromFile(string.Format(@"D:\development\Less.Net\LessCss.Specs\less\{0}.less", s));
		}

		private static StyleDocument getCss(string s)
		{
			return StyleDocument.FromFile(string.Format(@"D:\development\Less.Net\LessCss.Specs\css\{0}.css", s));
		}
	}
}
