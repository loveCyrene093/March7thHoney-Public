using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EnterRogueEndlessActivityStageScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EnterRogueEndlessActivityStageScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "CilFbnRlclJvZ3VlRW5kbGVzc0FjdGl2aXR5U3RhZ2VTY1JzcC5wcm90bxoR";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "REdESEJBR0VPT0kucHJvdG8aFVNjZW5lQmF0dGxlSW5mby5wcm90byKAAQoj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "RW50ZXJSb2d1ZUVuZGxlc3NBY3Rpdml0eVN0YWdlU2NSc3ASJQoLYmF0dGxl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "X2luZm8YAyABKAsyEC5TY2VuZUJhdHRsZUluZm8SDwoHcmV0Y29kZRgLIAEo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "DRIhCgtCTk9DRVBLTVBHSxgMIAEoCzIMLkRHREhCQUdFT09JQhaqAhNNYXJj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[2]
		{
			DGDHBAGEOOIReflection.Descriptor,
			SceneBattleInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EnterRogueEndlessActivityStageScRsp), EnterRogueEndlessActivityStageScRsp.Parser, new string[3] { "BattleInfo", "Retcode", "BNOCEPKMPGK" }, null, null, null, null)
		}));
	}
}
