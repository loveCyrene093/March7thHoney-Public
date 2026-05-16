using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EnterFeverTimeActivityStageScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EnterFeverTimeActivityStageScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CiZFbnRlckZldmVyVGltZUFjdGl2aXR5U3RhZ2VTY1JzcC5wcm90bxoVU2Nl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "bmVCYXR0bGVJbmZvLnByb3RvImYKIEVudGVyRmV2ZXJUaW1lQWN0aXZpdHlT";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "dGFnZVNjUnNwEiUKC2JhdHRsZV9pbmZvGAIgASgLMhAuU2NlbmVCYXR0bGVJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "bmZvEg8KB3JldGNvZGUYByABKA0SCgoCaWQYCiABKA1CFqoCE01hcmNoN3Ro";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "SG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { SceneBattleInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EnterFeverTimeActivityStageScRsp), EnterFeverTimeActivityStageScRsp.Parser, new string[3] { "BattleInfo", "Retcode", "Id" }, null, null, null, null)
		}));
	}
}
