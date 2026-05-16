using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeTrialActivityRewardScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeTrialActivityRewardScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJUYWtlVHJpYWxBY3Rpdml0eVJld2FyZFNjUnNwLnByb3RvGg5JdGVtTGlz" + "dC5wcm90byJcChxUYWtlVHJpYWxBY3Rpdml0eVJld2FyZFNjUnNwEhAKCHN0" + "YWdlX2lkGAQgASgNEhkKBnJld2FyZBgHIAEoCzIJLkl0ZW1MaXN0Eg8KB3Jl" + "dGNvZGUYCSABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeTrialActivityRewardScRsp), TakeTrialActivityRewardScRsp.Parser, new string[3] { "StageId", "Reward", "Retcode" }, null, null, null, null)
		}));
	}
}
