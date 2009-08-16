using System.IO;
using LessCss.Loaders;

namespace LessCss.Specs
{
	internal static class SpecHelper
	{
		private static readonly IDocumentLoader loader = new LessDocumentLoader();

		public static string Lessify(string name)
		{
			var filename = Path.Combine("less", name + ".less");
			var document = loader.LoadFromString(File.ReadAllText(filename));
			return document.Flatten().Evaluate().Merge().ToCss();
		}

		public static string Css(string name)
		{
			var filename = Path.Combine("css", name + ".css");
			return loader.LoadFromString(File.ReadAllText(filename)).Flatten().Merge().ToCss();
		}
	}
}
