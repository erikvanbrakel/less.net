using System.Text;

namespace LessCss.Helpers
{
	public static class PrettyPrintHelper
	{
		public static string PrettyPrint(this StyleDocument document)
		{
			var sb = new StringBuilder();
			sb.AppendLine("Variables:");
			document.Variables.ForEach(v => sb.AppendLine("\t" + v.PrettyPrint()));
			sb.AppendLine("Rules:");
			document.Rules.ForEach(r => sb.AppendLine(r.PrettyPrint()));
			return sb.ToString();			
		}

		public static string PrettyPrint(this StyleProperty property)
		{
			return string.Format("{0}: {1}", property.Name, property.Values);
		}

		public static string PrettyPrint(this StyleRule rule)
		{
			return PrettyPrint(rule, 1);
		}

		public static string PrettyPrint(this StyleRule rule, int tabcount)
		{
			var sb = new StringBuilder();
			var tabs = new string(' ', tabcount * 2);

			if (rule.Selectors.Count > 0)
			{
				sb.Append(tabs);
				sb.AppendLine("Selectors:");
				rule.Selectors.ForEach(s =>
				{
					sb.Append(tabs);
					sb.Append("  ");
					sb.AppendLine(s.PrettyPrint());
				});
			}
			if (rule.Properties.Count > 0)
			{
				sb.Append(tabs);
				sb.AppendLine("Properties:");
				rule.Properties.ForEach(p =>
				{
					sb.Append(tabs);
					sb.Append("  ");
					sb.AppendLine(p.PrettyPrint());
				});
			}
			if (rule.Rules.Count > 0)
			{
				sb.Append(tabs);
				sb.AppendLine("Rules:");
				rule.Rules.ForEach(r => sb.AppendLine(r.PrettyPrint(tabcount + 1)));
			}
			return sb.ToString();
		}


		public static string PrettyPrint(this StyleSelector selector)
		{
			return selector.Name;
		}

		public static string PrettyPrint(this StyleVariable variable)
		{
			return string.Format("{0}: {1}", variable.Name, variable.Value);
		}


	}
}