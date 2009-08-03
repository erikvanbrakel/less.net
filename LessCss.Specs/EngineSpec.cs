using Machine.Specifications;

namespace LessCss.Specs
{
	/// <summary>
	/// NOTE! SPECS DON'T WORK YET.
	/// </summary>
	public class EngineSpec
	{
		It should_parse_css = () => SpecHelper.Lessify("css").ShouldEqual(SpecHelper.Css("css"));
		It should_group_selectors_when_it_can = () => SpecHelper.Lessify("selectors").ShouldEqual(SpecHelper.Css("selectors"));
		It should_parse_css3 = () => SpecHelper.Lessify("css-3").ShouldEqual(SpecHelper.Css("css-3"));
		It should_parse_comments = () => SpecHelper.Lessify("comments").ShouldEqual(SpecHelper.Css("comments"));
		It should_deal_with_whitespace = () => SpecHelper.Lessify("whitespace").ShouldEqual(SpecHelper.Css("whitespace"));
		It should_parse_nested_rules = () => SpecHelper.Lessify("rulesets").ShouldEqual(SpecHelper.Css("rulesets"));
		It should_parse_variables = () => SpecHelper.Lessify("variables").ShouldEqual(SpecHelper.Css("variables"));
		It should_parse_operations = () => SpecHelper.Lessify("operations").ShouldEqual(SpecHelper.Css("operations"));
		It should_manage_scope = () => SpecHelper.Lessify("scope").ShouldEqual(SpecHelper.Css("scope"));
		It should_parse_parens = () => SpecHelper.Lessify("parens").ShouldEqual(SpecHelper.Css("parens"));
		It should_parse_strings = () => SpecHelper.Lessify("strings").ShouldEqual(SpecHelper.Css("strings"));
		It should_parse_accessors = () => SpecHelper.Lessify("accessors").ShouldEqual(SpecHelper.Css("accessors"));
		It should_parse_colors_in_hex = () => SpecHelper.Lessify("colors").ShouldEqual(SpecHelper.Css("colors"));
		It should_parse_mixins = () => SpecHelper.Lessify("mixins").ShouldEqual(SpecHelper.Css("mixins"));
		It should_parse_mixins_with_arguments = () => SpecHelper.Lessify("mixins-args").ShouldEqual(SpecHelper.Css("mixins-args"));
		It should_evaluate_variables_lazily = () => SpecHelper.Lessify("lazy-eval").ShouldEqual(SpecHelper.Css("lazy-eval"));
		It should_handle_custom_functions;
		It should_work_with_import = () => SpecHelper.Lessify("import").ShouldEqual(SpecHelper.Css("import"));
		It should_parse_a_big_file = () => SpecHelper.Lessify("big").ShouldEqual(SpecHelper.Css("big"));
		It should_handle_complex_operations;
	}
}