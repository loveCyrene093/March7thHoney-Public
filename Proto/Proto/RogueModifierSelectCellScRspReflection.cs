using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueModifierSelectCellScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueModifierSelectCellScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiJSb2d1ZU1vZGlmaWVyU2VsZWN0Q2VsbFNjUnNwLnByb3RvGg5JdGVtTGlz";
		buffer[1] = "dC5wcm90byJkChxSb2d1ZU1vZGlmaWVyU2VsZWN0Q2VsbFNjUnNwEg8KB3Jl";
		buffer[2] = "dGNvZGUYAiABKA0SEwoLRUlJQUdBQkFGRUMYCSABKA0SHgoLRk5MREZHTEdF";
		buffer[3] = "T0EYCyABKAsyCS5JdGVtTGlzdEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG";
		buffer[4] = "cHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueModifierSelectCellScRsp), RogueModifierSelectCellScRsp.Parser, new string[3] { "Retcode", "EIIAGABAFEC", "FNLDFGLGEOA" }, null, null, null, null)
		}));
	}
}
