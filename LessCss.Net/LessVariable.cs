using Antlr.Runtime.Tree;

namespace LessCss
{
	public class LessVariable
	{
		private string Name;
		private string Value;

		public static LessVariable ParseTree(BaseTree tree)
		{
			var variable = new LessVariable { Name = ((BaseTree)tree.Children[0]).Text };

			for (var i = 1; i < tree.Children.Count; i++)
			{
				var node = (BaseTree)tree.Children[i];
				variable.Value += " " + node.Text;
			}

			return variable;
		}

		public string PrettyPrint()
		{
			return string.Format("{0}: {1}", Name, Value);
		}
	}
}