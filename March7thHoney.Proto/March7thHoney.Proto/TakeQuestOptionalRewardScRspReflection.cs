using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeQuestOptionalRewardScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeQuestOptionalRewardScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJUYWtlUXVlc3RPcHRpb25hbFJld2FyZFNjUnNwLnByb3RvGg5JdGVtTGlz" + "dC5wcm90byJcChxUYWtlUXVlc3RPcHRpb25hbFJld2FyZFNjUnNwEhAKCHF1" + "ZXN0X2lkGAMgASgNEg8KB3JldGNvZGUYCCABKA0SGQoGcmV3YXJkGAkgASgL" + "MgkuSXRlbUxpc3RCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeQuestOptionalRewardScRsp), TakeQuestOptionalRewardScRsp.Parser, new string[3] { "QuestId", "Retcode", "Reward" }, null, null, null, null)
		}));
	}
}
