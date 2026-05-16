using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AlleyTakeEventRewardScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AlleyTakeEventRewardScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9BbGxleVRha2VFdmVudFJld2FyZFNjUnNwLnByb3RvGg5JdGVtTGlzdC5w" + "cm90byJHChlBbGxleVRha2VFdmVudFJld2FyZFNjUnNwEg8KB3JldGNvZGUY" + "AiABKA0SGQoGcmV3YXJkGAcgASgLMgkuSXRlbUxpc3RCFqoCE01hcmNoN3Ro" + "SG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AlleyTakeEventRewardScRsp), AlleyTakeEventRewardScRsp.Parser, new string[2] { "Retcode", "Reward" }, null, null, null, null)
		}));
	}
}
