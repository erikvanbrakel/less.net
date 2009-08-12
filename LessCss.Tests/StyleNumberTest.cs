using NUnit.Framework;

namespace LessCss.Tests
{
	public partial class StyleNumberTest
	{
		[Test]
		public void Operators_ComplexCalculation_CorrectResult()
		{
			var s1 = new StyleNumber(10);
			var s2 = new StyleNumber(12);
			var s3 = new StyleNumber(444);
			var s4 = new StyleNumber(26);
			var s5 = new StyleNumber(33);
			var s6 = new StyleNumber(12);
			var s7 = new StyleNumber(95);
			var s8 = new StyleNumber(3);

			var result = s2 + s1*s3/(s4 + s6) + s5 + s7/s8;
			((StyleNumber)result).Value.Should().Be.EqualTo(12m + 10m*444m / (26m + 12m) + 33m + 95m/3m);
		}
	}
}
