using System;
using NUnit.Framework;

namespace LessCss.Tests
{
	[TestFixture]
	public partial class StyleNumberTest
	{
		[Test]
		public void Mul_MixedUnitsOfMeasure_ExceptionThrown()
		{
			var s1 = new StyleNumber(10, "cm");
			var s2 = new StyleNumber(10, "px");

			Assert.Throws<ArgumentException>(() => { var s = s1 * s2; });
		}

		[Test]
		public void Mul_OneUnitOfMeasure_UseUnitOfMeasure()
		{
			var s1 = new StyleNumber(10, "cm");
			var s2 = new StyleNumber(10, "");

			((StyleNumber)(s1 * s2)).UnitOfMeasure.Should().Be.EqualTo("cm");
			((StyleNumber)(s2 * s1)).UnitOfMeasure.Should().Be.EqualTo("cm");
		}
	}
}
