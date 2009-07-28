using Antlr.Runtime.Tree;

namespace LessCss
{
	public class LessSelector
	{
		public string Name { get; set; }
		private string SelectorType { get; set; }

		public static LessSelector ParseTree(BaseTree tree)
		{
			return new LessSelector {SelectorType = tree.Text, Name = ((BaseTree) tree.GetChild(0)).Text};
		}

		public string PrettyPrint()
		{
			var typeToken = SelectorType == "TAG" ? "" : SelectorType == "CLASS" ? "." : "#";
			return typeToken + Name;
		}

		public string ToCss()
		{
			return PrettyPrint();
		}
	}
}