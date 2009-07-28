using System.IO;
using NUnit.Framework;
using Machine.Specifications;

namespace LessCss.Specs
{
	/// <summary>
	/// NOTE! SPECS DON'T WORK YET.
	/// </summary>
	public class Engine
	{
		It should_parse_css;
		It should_group_selectors_when_it_can;
		It should_parse_css3;
		It should_parse_comments = () => Assert.AreEqual(SpecHelper.Lessify("comments"), SpecHelper.Css("comments"));
		It should_deal_with_whitespace;
		It should_parse_nested_rules;
		It should_parse_variables;
		It should_parse_operations;
		It should_manage_scope;
		It should_parse_parens;
		It should_parse_strings;
		It should_parse_accessors;
		It should_parse_colors_in_hex;
		It should_parse_mixins;
		It should_parse_mixins_with_arguments;
		It should_evaluate_variables_lazily;
		It should_handle_custom_functions;
		It should_work_with_import;
		It should_parse_a_big_file;
		It should_handle_complex_operations;
	}

	internal static class SpecHelper
	{
		public static string Lessify(string name)
		{
			var filename = Path.Combine("less", name + ".less");
			var document = LessDocument.FromFile(filename);
			return document.ToCss();
		}

		public static string Css(string name)
		{
			var filename = Path.Combine("css", name + ".css");
			return File.ReadAllText(filename);
		}
	}
}
