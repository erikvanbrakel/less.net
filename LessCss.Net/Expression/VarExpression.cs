using System.Collections.Generic;

namespace LessCss.Expression
{
	internal class VarExpression : StyleExpression
	{
		public readonly string Varname;

		public VarExpression(string value)
		{
			Varname = value;
		}

		public override StyleExpression Reduce(List<StyleVariable> variables)
		{
			var variable = variables.Find(v => v.Name == Varname);
			if (variable == null) return this;
			return variable.Value;
		}

		public bool Equals(VarExpression obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			return Equals(obj.Varname, Varname);
		}

		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			if (obj.GetType() != typeof (VarExpression)) return false;
			return Equals((VarExpression) obj);
		}

		public override int GetHashCode()
		{
			return Varname.GetHashCode();
		}
	}
}