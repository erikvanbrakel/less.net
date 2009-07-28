using Antlr.Runtime.Tree;

namespace LessCss
{
	public class LessProperty
	{
		private string Name;
		private string Value;

		public static LessProperty ParseTree(BaseTree tree)
		{
			var property = new LessProperty {Name = ((BaseTree) tree.Children[0]).Text};

			for(var i=1; i<tree.Children.Count;i++)
			{
				var node = (BaseTree)tree.Children[i];
				property.Value += " " + node.Text;
			}

			return property;
		}

		public string PrettyPrint()
		{
			return string.Format("{0}: {1}", Name, Value);
		}

		public string ToCss()
		{
			return string.Format("{0}:{1};",Name, Value);
		}
	}
}