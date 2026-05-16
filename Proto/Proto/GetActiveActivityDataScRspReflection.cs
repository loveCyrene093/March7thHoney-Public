using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetActiveActivityDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetActiveActivityDataScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiBHZXRBY3RpdmVBY3Rpdml0eURhdGFTY1JzcC5wcm90bxoYQWN0aXZlQWN0";
		buffer[1] = "aXZpdHlEYXRhLnByb3RvIlcKGkdldEFjdGl2ZUFjdGl2aXR5RGF0YVNjUnNw";
		buffer[2] = "EigKC1BJRExPR0hISERMGAEgAygLMhMuQWN0aXZlQWN0aXZpdHlEYXRhEg8K";
		buffer[3] = "B3JldGNvZGUYCiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv";
		buffer[4] = "Mw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ActiveActivityDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetActiveActivityDataScRsp), GetActiveActivityDataScRsp.Parser, new string[2] { "PIDLOGHHHDL", "Retcode" }, null, null, null, null)
		}));
	}
}
