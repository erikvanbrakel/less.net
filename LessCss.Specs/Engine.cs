using System.IO;

namespace LessCss.Specs
{
	internal static class SpecHelper
	{
		public static string Lessify(string name)
		{
			var filename = Path.Combine("less", name + ".less");
			var document = StyleDocument.FromFile(filename);
			return document.Flatten().Evaluate().Merge().ToCss();
		}

		public static string Css(string name)
		{
			var filename = Path.Combine("css", name + ".css");
			return StyleDocument.FromFile(filename).Flatten().Merge().ToCss();
		}
	}
}
