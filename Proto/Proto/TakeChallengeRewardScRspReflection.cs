using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeChallengeRewardScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeChallengeRewardScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "Ch5UYWtlQ2hhbGxlbmdlUmV3YXJkU2NSc3AucHJvdG8aHlRha2VuQ2hhbGxl";
		buffer[1] = "bmdlUmV3YXJkSW5mby5wcm90byJzChhUYWtlQ2hhbGxlbmdlUmV3YXJkU2NS";
		buffer[2] = "c3ASNAoRdGFrZW5fcmV3YXJkX2xpc3QYBSADKAsyGS5UYWtlbkNoYWxsZW5n";
		buffer[3] = "ZVJld2FyZEluZm8SDwoHcmV0Y29kZRgMIAEoDRIQCghncm91cF9pZBgPIAEo";
		buffer[4] = "DUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { TakenChallengeRewardInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeChallengeRewardScRsp), TakeChallengeRewardScRsp.Parser, new string[3] { "TakenRewardList", "Retcode", "GroupId" }, null, null, null, null)
		}));
	}
}
