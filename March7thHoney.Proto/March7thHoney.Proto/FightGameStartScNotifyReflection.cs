using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FightGameStartScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FightGameStartScNotifyReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChxGaWdodEdhbWVTdGFydFNjTm90aWZ5LnByb3RvGhFBREhOSkFESUpBQy5w";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "cm90bxoRSUZDQkNCTEZBTE0ucHJvdG8iXgoWRmlnaHRHYW1lU3RhcnRTY05v";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "dGlmeRIhCgtPUE9HRU1BRExFSRgCIAEoCzIMLklGQ0JDQkxGQUxNEiEKC0JJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "RUJGSEVDRVBNGAYgAygLMgwuQURITkpBRElKQUNCFqoCE01hcmNoN3RoSG9u";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "ZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			ADHNJADIJACReflection.Descriptor,
			IFCBCBLFALMReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FightGameStartScNotify), FightGameStartScNotify.Parser, new string[2] { "OPOGEMADLEI", "BIEBFHECEPM" }, null, null, null, null)
		}));
	}
}
