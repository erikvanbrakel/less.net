using System;
using System.IO;
using System.Text;
using LessCss;
using LessCss.Loaders;

namespace LessCompiler
{
	class LessCompiler
	{
		readonly IDocumentLoader loader;

		static void Main(string[] args)
		{
			args = new[] {"-c",@"d:\development\lesscss\LessCss.Specs\less\variables.less"};
			var arguments = new CommandLineArguments(args);

			if(arguments.ShowUsage)
			{
				ShowUsage();
				return;
			}

			var compiler = Create(arguments);
			using (var input = new FileStream(arguments.InputFilename,FileMode.Open, FileAccess.Read))
			{
				var output = compiler.Compile(input);

				if (arguments.OutputToConsole)
				{
					Console.Write(output);
				}
				else
				{
					File.WriteAllText(arguments.OutputFilename, output);
				}
			}
		}

		public string Compile(Stream input)
		{
			using (var reader = new StreamReader(input))
			{
				var document = loader.LoadFromString(reader.ReadToEnd());
				return document.ToCss();
			}
		}

		public LessCompiler(IDocumentLoader loader)
		{
			this.loader = loader;
		}

		public static LessCompiler Create(CommandLineArguments arguments)
		{
			var compiler = new LessCompiler(new LessDocumentLoader());
			return compiler;
		}

		private static void ShowUsage()
		{
			var usage = new StringBuilder();
			usage.AppendLine("Usage: lessc [OPTIONS] filename");
			usage.AppendLine("==================================");
			usage.AppendLine("Options:");
			usage.AppendLine("==================================");
			usage.AppendLine("-v: verbose output. Logging to console");
			usage.AppendLine(
			"-c: Output to console instead of output file");
			usage.AppendLine(
			"-o <filename>: Output to specified filename");
			usage.AppendLine("-?: Show this usage list");

			Console.Write(usage.ToString());
		}

		private static StyleDocument getLess(string s)
		{
			return
				new LessDocumentLoader().LoadFromString(
					File.ReadAllText(string.Format(@"D:\development\Less.Net\LessCss.Specs\less\{0}.less", s)));
			//return StyleDocument.FromFile(string.Format(@"D:\development\Less.Net\LessCss.Specs\less\{0}.less", s));
		}

		private static StyleDocument getCss(string s)
		{
			return
				new LessDocumentLoader().LoadFromString(
					File.ReadAllText(string.Format(@"D:\development\Less.Net\LessCss.Specs\css\{0}.css", s)));
			//return StyleDocument.FromFile(string.Format(@"D:\development\Less.Net\LessCss.Specs\css\{0}.css", s));
		}
	}

	internal class CommandLineArguments
	{
		public string InputFilename { get; set; }
		public string OutputFilename { get; set; }
		public bool Verbose { get; set; }
		public bool OutputToConsole { get; set; }
		public bool ShowUsage { get; set; }

		public CommandLineArguments(string[] arguments)
		{
			if (arguments.Length == 0)
			{
				ShowUsage = true;
				return;
			}

			for(var i=0;i<arguments.Length;i++)
			{
				switch(arguments[i])
				{
					case "-v": Verbose = true; break;
					case "-o":
						if (i + 1 == arguments.Length || arguments[i + 1].StartsWith("-"))
							throw new ArgumentException("option -o should be followed by a filename!");
						if (OutputToConsole)
							throw new ArgumentException("options -o and -c are mutually exclusive!");
						OutputFilename = arguments[++i];
						break;
					case "-c":
						if (!string.IsNullOrEmpty(OutputFilename))
							throw new ArgumentException("options -o and -c are mutually exclusive!");
						OutputToConsole = true;
						break;
					case "-?":
						ShowUsage = true;
						break;
					default:
						InputFilename = arguments[i];
						break;
				}
			}
		}
	}
}
