using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EnterFantasticStoryActivityStageScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EnterFantasticStoryActivityStageScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "CitFbnRlckZhbnRhc3RpY1N0b3J5QWN0aXZpdHlTdGFnZVNjUnNwLnByb3Rv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "GhVTY2VuZUJhdHRsZUluZm8ucHJvdG8ihwEKJUVudGVyRmFudGFzdGljU3Rv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "cnlBY3Rpdml0eVN0YWdlU2NSc3ASDwoHcmV0Y29kZRgEIAEoDRIlCgtiYXR0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "bGVfaW5mbxgHIAEoCzIQLlNjZW5lQmF0dGxlSW5mbxIRCgliYXR0bGVfaWQY";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "CiABKA0SEwoLQ0VJTU5ESkZESkQYDCABKA1CFqoCE01hcmNoN3RoSG9uZXku";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "UHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[1] { SceneBattleInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EnterFantasticStoryActivityStageScRsp), EnterFantasticStoryActivityStageScRsp.Parser, new string[4] { "Retcode", "BattleInfo", "BattleId", "CEIMNDJFDJD" }, null, null, null, null)
		}));
	}
}
