using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChallengeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChallengeReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "Cg9DaGFsbGVuZ2UucHJvdG8aGENoYWxsZW5nZVN0YWdlSW5mby5wcm90byK7";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "AQoJQ2hhbGxlbmdlEhEKCXNjb3JlX3R3bxgBIAEoDRITCgtESU9IS01QUEtI";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "QRgCIAEoCBIRCglyZWNvcmRfaWQYBSABKA0SFAoMdGFrZW5fcmV3YXJkGAYg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "ASgNEhAKCHNjb3JlX2lkGAggASgNEhQKDGNoYWxsZW5nZV9pZBgJIAEoDRIn";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "CgpzdGFnZV9pbmZvGAogASgLMhMuQ2hhbGxlbmdlU3RhZ2VJbmZvEgwKBHN0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "YXIYDiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[1] { ChallengeStageInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(Challenge), Challenge.Parser, new string[8] { "ScoreTwo", "DIOHKMPPKHA", "RecordId", "TakenReward", "ScoreId", "ChallengeId", "StageInfo", "Star" }, null, null, null, null)
		}));
	}
}
