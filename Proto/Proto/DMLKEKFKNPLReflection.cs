using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DMLKEKFKNPLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DMLKEKFKNPLReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChFETUxLRUtGS05QTC5wcm90bxoXR3JpZEZpZ2h0RHJvcEluZm8ucHJvdG8i";
		buffer[1] = "1QEKC0RNTEtFS0ZLTlBMEhEKCWVmZmVjdF9pZBgBIAEoDRITCgtzd2l0Y2hf";
		buffer[2] = "bGlzdBgCIAMoDRJLChl0cmFpdF9lZmZlY3RfbGV2ZWxfcmV3YXJkGAUgAygL";
		buffer[3] = "MiguRE1MS0VLRktOUEwuVHJhaXRFZmZlY3RMZXZlbFJld2FyZEVudHJ5GlEK";
		buffer[4] = "G1RyYWl0RWZmZWN0TGV2ZWxSZXdhcmRFbnRyeRILCgNrZXkYASABKA0SIQoF";
		buffer[5] = "dmFsdWUYAiABKAsyEi5HcmlkRmlnaHREcm9wSW5mbzoCOAFCFqoCE01hcmNo";
		buffer[6] = "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { GridFightDropInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DMLKEKFKNPL), DMLKEKFKNPL.Parser, new string[3] { "EffectId", "SwitchList", "TraitEffectLevelReward" }, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
