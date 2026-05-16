using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeHipplenEndingRewardScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeHipplenEndingRewardScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiJUYWtlSGlwcGxlbkVuZGluZ1Jld2FyZFNjUnNwLnByb3RvGg5JdGVtTGlz";
		buffer[1] = "dC5wcm90byJkChxUYWtlSGlwcGxlbkVuZGluZ1Jld2FyZFNjUnNwEh4KC3Jl";
		buffer[2] = "d2FyZF9saXN0GAIgASgLMgkuSXRlbUxpc3QSEwoLREtQQ0RMRERPTkcYDSAB";
		buffer[3] = "KA0SDwoHcmV0Y29kZRgOIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG";
		buffer[4] = "cHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeHipplenEndingRewardScRsp), TakeHipplenEndingRewardScRsp.Parser, new string[3] { "RewardList", "DKPCDLDDONG", "Retcode" }, null, null, null, null)
		}));
	}
}
