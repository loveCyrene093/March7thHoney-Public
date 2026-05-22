using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FeverTimeActivityBattleEndScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FeverTimeActivityBattleEndScNotifyReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "CihGZXZlclRpbWVBY3Rpdml0eUJhdHRsZUVuZFNjTm90aWZ5LnByb3RvGhlG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "ZXZlclRpbWVCYXR0bGVSYW5rLnByb3RvIoMBCiJGZXZlclRpbWVBY3Rpdml0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "eUJhdHRsZUVuZFNjTm90aWZ5EikKC0tJS0NES0xLQ1BDGAUgASgOMhQuRmV2";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "ZXJUaW1lQmF0dGxlUmFuaxIKCgJpZBgLIAEoDRITCgtQS1BJT0lKUFBCTBgM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "IAEoDRIRCgl0dXJuX2xlZnQYDSABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "dG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[1] { FeverTimeBattleRankReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FeverTimeActivityBattleEndScNotify), FeverTimeActivityBattleEndScNotify.Parser, new string[4] { "KIKCDKLKCPC", "Id", "PKPIOIJPPBL", "TurnLeft" }, null, null, null, null)
		}));
	}
}
