using System;
using Microsoft.CodeAnalysis;

namespace SourceGeneration5 {
	[Generator]
	public class SourceGenerator : ISourceGenerator {

		public void Execute(GeneratorExecutionContext context) {
			string source = $@"
namespace ConsoleApp {{
	static partial class Program {{

		static partial void Hello() {{
			System.Console.WriteLine(""hello"");
		}}

	}}
}}
";

			context.AddSource("GeneratedSource", source);
		}

		public void Initialize(GeneratorInitializationContext context) {

		}

	}
}
