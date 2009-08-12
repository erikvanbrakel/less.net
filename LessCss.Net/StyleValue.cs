using System;
using System.Globalization;

namespace LessCss
{
	public abstract class StyleValue
	{
		public decimal GetValue()
		{
			return 0;
		}

		public static StyleValue operator +(StyleValue left, StyleValue right)
		{
			return left.Add(right);
		}
		public static StyleValue operator -(StyleValue left, StyleValue right)
		{
			return left.Sub(right);
		}
		public static StyleValue operator *(StyleValue left, StyleValue right)
		{
			return left.Mul(right);
		}
		public static StyleValue operator /(StyleValue left, StyleValue right)
		{
			return left.Div(right);
		}

		protected virtual StyleValue Sub(StyleValue right)
		{
			return new StyleNumber(0);
		}

		protected virtual StyleValue Mul(StyleValue right)
		{
			return new StyleNumber(0);
		}

		protected virtual StyleValue Add(StyleValue right)
		{
			return new StyleNumber(0);
		}

		protected virtual StyleValue Div(StyleValue right)
		{
			return new StyleNumber(0);
		}
	}

	/// <summary>
	/// #9f9 / #fffa1d
	/// </summary>
	class StyleColor : StyleValue
	{
		private int Value;

		private StyleColor()
		{
		}

		public override string ToString()
		{
			return string.Format("#{0:X6}", Value);
		}

		public StyleColor(string val)
		{
			
			if (val.Length == 4)
			{
				val += val.Substring(1);
			}
			else if (val.Length != 7)
				throw new ArgumentException();
			
			Value = int.Parse(val.Substring(1), NumberStyles.HexNumber);
		}

		protected override StyleValue Div(StyleValue right)
		{
			if(right is StyleColor)
			{
				var other = right as StyleColor;
				return new StyleColor {Value = Value/other.Value};
			}
			if(right is StyleNumber)
			{
				var other = right as StyleNumber;
				if(!string.IsNullOrEmpty(other.UnitOfMeasure))
				{
					throw new ArgumentException();
				}
				return new StyleColor {Value = (int)(Value/other.Value)};
			}
			throw new ArgumentException();
		}
	}

	/// <summary>
	/// Anything composed of a value (double) and a unit of measure
	/// </summary>
	public class StyleNumber : StyleValue
	{
		public decimal Value;
		public string UnitOfMeasure;

		public override string ToString()
		{
			return Value + UnitOfMeasure;
		}

		public StyleNumber(decimal value, string unitofmeasure)
		{
			Value = value;
			UnitOfMeasure = string.IsNullOrEmpty(unitofmeasure) ? null : unitofmeasure;
		}

		public StyleNumber(decimal value)
		{
			Value = value;
		}

		private bool CanOperateOn(StyleNumber other)
		{
			var sameUoM = UnitOfMeasure == other.UnitOfMeasure;
			var NoUoM = string.IsNullOrEmpty(UnitOfMeasure) || string.IsNullOrEmpty(other.UnitOfMeasure);
			return sameUoM || NoUoM;
		}

		protected override StyleValue Mul(StyleValue right)
		{
			if(right is StyleNumber)
			{
				var other = right as StyleNumber;
				if (!CanOperateOn(other)) throw new ArgumentException();
				return new StyleNumber(Value * other.Value, UnitOfMeasure ?? other.UnitOfMeasure);				
			}
			throw new ArgumentException();
		}

		protected override StyleValue Add(StyleValue right)
		{
			if (right is StyleNumber)
			{
				var other = right as StyleNumber;
				if (!CanOperateOn(other)) throw new ArgumentException();
				return new StyleNumber(Value + other.Value, UnitOfMeasure ?? other.UnitOfMeasure);
			}
			throw new ArgumentException();
		}

		protected override StyleValue Div(StyleValue right)
		{
			if (right is StyleNumber)
			{
				var other = right as StyleNumber;
				if (!CanOperateOn(other)) throw new ArgumentException();
				return new StyleNumber(Value / other.Value, UnitOfMeasure ?? other.UnitOfMeasure);
			}
			throw new ArgumentException();
		}

		protected override StyleValue Sub(StyleValue right)
		{
			if (right is StyleNumber)
			{
				var other = right as StyleNumber;
				if (!CanOperateOn(other)) throw new ArgumentException();
				return new StyleNumber(Value - other.Value, UnitOfMeasure ?? other.UnitOfMeasure);
			}
			throw new ArgumentException();
		}
	}
}
