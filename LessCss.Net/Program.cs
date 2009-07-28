using System;

namespace LessCss
{
	static class Program
	{
		public static void Main(string[] args)
		{
			var input = @".whitespace
  { color: white; }  
.whitespace
{
  color: white;
}
  .whitespace
{ color: white; }

.whitespace{color:white;}  
.whitespace { color : white ; }

.white,
.space,
.mania
{ color: white; }

.no-semi-column { color: white; }
.no-semi-column {
  color: white;
  white-space: pre;
}
.newlines {
  border: 2px
          solid
          black;
}
.empty {
  
}
";
			var lessDoc = LessDocument.FromString(input);
			Console.Write(lessDoc.ToCss());
			Console.ReadKey();

		}
	}
}
