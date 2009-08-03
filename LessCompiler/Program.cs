using System;
using LessCss;

namespace LessCompiler
{
	class Program
	{
		static void Main(string[] args)
		{
			var testcase = "css";
			var less = getLess(testcase).Flatten().Merge();
			var css = getCss(testcase).Flatten().Merge();

			Console.WriteLine(less.ToCss());
			Console.WriteLine(css.ToCss());
			Console.Write(less.Equals(css));
			Console.ReadKey();
		}

		private static StyleDocument getLess(string s)
		{
			return StyleDocument.FromFile(string.Format(@"D:\development\LessCss.Net\LessCss.Specs\less\{0}.less", s));
		}

		private static StyleDocument getCss(string s)
		{
			return StyleDocument.FromFile(string.Format(@"D:\development\LessCss.Net\LessCss.Specs\css\{0}.css", s));
		}
	}
}
