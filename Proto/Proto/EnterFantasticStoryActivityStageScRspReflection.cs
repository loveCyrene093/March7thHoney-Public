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
		buffer[0] = "CitFbnRlckZhbnRhc3RpY1N0b3J5QWN0aXZpdHlTdGFnZVNjUnNwLnByb3Rv";
		buffer[1] = "GhVTY2VuZUJhdHRsZUluZm8ucHJvdG8ihwEKJUVudGVyRmFudGFzdGljU3Rv";
		buffer[2] = "cnlBY3Rpdml0eVN0YWdlU2NSc3ASDwoHcmV0Y29kZRgEIAEoDRIlCgtiYXR0";
		buffer[3] = "bGVfaW5mbxgHIAEoCzIQLlNjZW5lQmF0dGxlSW5mbxIRCgliYXR0bGVfaWQY";
		buffer[4] = "CiABKA0SEwoLQ0VJTU5ESkZESkQYDCABKA1CFqoCE01hcmNoN3RoSG9uZXku";
		buffer[5] = "UHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { SceneBattleInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EnterFantasticStoryActivityStageScRsp), EnterFantasticStoryActivityStageScRsp.Parser, new string[4] { "Retcode", "BattleInfo", "BattleId", "CEIMNDJFDJD" }, null, null, null, null)
		}));
	}
}
