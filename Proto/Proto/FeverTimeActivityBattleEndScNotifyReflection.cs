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
		buffer[0] = "CihGZXZlclRpbWVBY3Rpdml0eUJhdHRsZUVuZFNjTm90aWZ5LnByb3RvGhlG";
		buffer[1] = "ZXZlclRpbWVCYXR0bGVSYW5rLnByb3RvIoMBCiJGZXZlclRpbWVBY3Rpdml0";
		buffer[2] = "eUJhdHRsZUVuZFNjTm90aWZ5EikKC0tJS0NES0xLQ1BDGAUgASgOMhQuRmV2";
		buffer[3] = "ZXJUaW1lQmF0dGxlUmFuaxIKCgJpZBgLIAEoDRITCgtQS1BJT0lKUFBCTBgM";
		buffer[4] = "IAEoDRIRCgl0dXJuX2xlZnQYDSABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJv";
		buffer[5] = "dG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { FeverTimeBattleRankReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FeverTimeActivityBattleEndScNotify), FeverTimeActivityBattleEndScNotify.Parser, new string[4] { "KIKCDKLKCPC", "Id", "PKPIOIJPPBL", "TurnLeft" }, null, null, null, null)
		}));
	}
}
