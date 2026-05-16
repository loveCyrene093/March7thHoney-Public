using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MonopolyTakePhaseRewardScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MonopolyTakePhaseRewardScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiJNb25vcG9seVRha2VQaGFzZVJld2FyZFNjUnNwLnByb3RvGg5JdGVtTGlz";
		buffer[1] = "dC5wcm90byJkChxNb25vcG9seVRha2VQaGFzZVJld2FyZFNjUnNwEhMKC0ZG";
		buffer[2] = "SkVDQU1JRURMGAMgAygNEh4KC3Jld2FyZF9saXN0GAQgASgLMgkuSXRlbUxp";
		buffer[3] = "c3QSDwoHcmV0Y29kZRgOIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG";
		buffer[4] = "cHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyTakePhaseRewardScRsp), MonopolyTakePhaseRewardScRsp.Parser, new string[3] { "FFJECAMIEDL", "RewardList", "Retcode" }, null, null, null, null)
		}));
	}
}
