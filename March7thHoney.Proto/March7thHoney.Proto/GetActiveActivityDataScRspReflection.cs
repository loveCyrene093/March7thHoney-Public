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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CiBHZXRBY3RpdmVBY3Rpdml0eURhdGFTY1JzcC5wcm90bxoYQWN0aXZlQWN0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "aXZpdHlEYXRhLnByb3RvIlcKGkdldEFjdGl2ZUFjdGl2aXR5RGF0YVNjUnNw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "EigKC1BJRExPR0hISERMGAEgAygLMhMuQWN0aXZlQWN0aXZpdHlEYXRhEg8K";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "B3JldGNvZGUYCiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "Mw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { ActiveActivityDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetActiveActivityDataScRsp), GetActiveActivityDataScRsp.Parser, new string[2] { "PIDLOGHHHDL", "Retcode" }, null, null, null, null)
		}));
	}
}
