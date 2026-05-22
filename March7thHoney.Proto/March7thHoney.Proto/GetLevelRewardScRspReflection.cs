using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetLevelRewardScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetLevelRewardScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlHZXRMZXZlbFJld2FyZFNjUnNwLnByb3RvGg5JdGVtTGlzdC5wcm90byJQ" + "ChNHZXRMZXZlbFJld2FyZFNjUnNwEg0KBWxldmVsGAYgASgNEg8KB3JldGNv" + "ZGUYDCABKA0SGQoGcmV3YXJkGA0gASgLMgkuSXRlbUxpc3RCFqoCE01hcmNo" + "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetLevelRewardScRsp), GetLevelRewardScRsp.Parser, new string[3] { "Level", "Retcode", "Reward" }, null, null, null, null)
		}));
	}
}
