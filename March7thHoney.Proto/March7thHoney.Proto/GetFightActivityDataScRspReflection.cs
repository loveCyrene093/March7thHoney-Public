using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetFightActivityDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetFightActivityDataScRspReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 0) = "Ch9HZXRGaWdodEFjdGl2aXR5RGF0YVNjUnNwLnByb3RvGhFJRk5FQ0pPT0lH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 1) = "Ry5wcm90byLvAQoZR2V0RmlnaHRBY3Rpdml0eURhdGFTY1JzcBJACgtJTUdH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 2) = "UE1FT0pBShgBIAMoCzIrLkdldEZpZ2h0QWN0aXZpdHlEYXRhU2NSc3AuSU1H";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 3) = "R1BNRU9KQUpFbnRyeRITCgtJQkNNTERQSkdDSxgCIAEoCBIPCgdyZXRjb2Rl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 4) = "GAUgASgNEiEKC0VDR0xHREtERElEGAogAygLMgwuSUZORUNKT09JR0cSEwoL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 5) = "d29ybGRfbGV2ZWwYDiABKA0aMgoQSU1HR1BNRU9KQUpFbnRyeRILCgNrZXkY";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 6) = "ASABKA0SDQoFdmFsdWUYAiABKA06AjgBQhaqAhNNYXJjaDd0aEhvbmV5LlBy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 7) = "b3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray8<string>, string>(in buffer, 8))), new FileDescriptor[1] { IFNECJOOIGGReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetFightActivityDataScRsp), GetFightActivityDataScRsp.Parser, new string[5] { "IMGGPMEOJAJ", "IBCMLDPJGCK", "Retcode", "ECGLGDKDDID", "WorldLevel" }, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
