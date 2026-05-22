using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeTaskRewardScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeTaskRewardScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlUYWtlVGFza1Jld2FyZFNjUnNwLnByb3RvGg5JdGVtTGlzdC5wcm90byJB" + "ChNUYWtlVGFza1Jld2FyZFNjUnNwEg8KB3JldGNvZGUYASABKA0SGQoGcmV3" + "YXJkGA4gASgLMgkuSXRlbUxpc3RCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i" + "BnByb3RvMw=="), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeTaskRewardScRsp), TakeTaskRewardScRsp.Parser, new string[2] { "Retcode", "Reward" }, null, null, null, null)
		}));
	}
}
