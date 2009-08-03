using System.IO;

namespace LessCss.Specs
{
	internal static class SpecHelper
	{
		public static StyleDocument Lessify(string name)
		{
			var filename = Path.Combine("less", name + ".less");
			var document = StyleDocument.FromFile(filename);
			return document.Flatten().Merge();
		}

		public static StyleDocument Css(string name)
		{
			var filename = Path.Combine("css", name + ".css");
			return StyleDocument.FromFile(filename).Flatten().Merge();
		}
	}
}
