using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightTraitEffectLevelInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightTraitEffectLevelInfoReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		buffer[0] = "CiNHcmlkRmlnaHRUcmFpdEVmZmVjdExldmVsSW5mby5wcm90bxoXR3JpZEZp";
		buffer[1] = "Z2h0RHJvcEluZm8ucHJvdG8i8QEKHUdyaWRGaWdodFRyYWl0RWZmZWN0TGV2";
		buffer[2] = "ZWxJbmZvEh4KFnRyYWl0X2VmZmVjdF9sZXZlbF9leHAYASABKA0SXQoZdHJh";
		buffer[3] = "aXRfZWZmZWN0X2xldmVsX3Jld2FyZBgCIAMoCzI6LkdyaWRGaWdodFRyYWl0";
		buffer[4] = "RWZmZWN0TGV2ZWxJbmZvLlRyYWl0RWZmZWN0TGV2ZWxSZXdhcmRFbnRyeRpR";
		buffer[5] = "ChtUcmFpdEVmZmVjdExldmVsUmV3YXJkRW50cnkSCwoDa2V5GAEgASgNEiEK";
		buffer[6] = "BXZhbHVlGAIgASgLMhIuR3JpZEZpZ2h0RHJvcEluZm86AjgBQhaqAhNNYXJj";
		buffer[7] = "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { GridFightDropInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightTraitEffectLevelInfo), GridFightTraitEffectLevelInfo.Parser, new string[2] { "TraitEffectLevelExp", "TraitEffectLevelReward" }, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
