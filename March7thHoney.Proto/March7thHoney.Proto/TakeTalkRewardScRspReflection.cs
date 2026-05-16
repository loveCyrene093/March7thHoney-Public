using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeTalkRewardScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeTalkRewardScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlUYWtlVGFsa1Jld2FyZFNjUnNwLnByb3RvGg5JdGVtTGlzdC5wcm90byJW" + "ChNUYWtlVGFsa1Jld2FyZFNjUnNwEhMKC0pIT0FNSUxIQUlDGAEgASgNEg8K" + "B3JldGNvZGUYByABKA0SGQoGcmV3YXJkGAggASgLMgkuSXRlbUxpc3RCFqoC" + "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeTalkRewardScRsp), TakeTalkRewardScRsp.Parser, new string[3] { "JHOAMILHAIC", "Retcode", "Reward" }, null, null, null, null)
		}));
	}
}
