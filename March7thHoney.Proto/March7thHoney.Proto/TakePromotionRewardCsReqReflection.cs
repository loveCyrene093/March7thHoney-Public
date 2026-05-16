using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakePromotionRewardCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakePromotionRewardCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5UYWtlUHJvbW90aW9uUmV3YXJkQ3NSZXEucHJvdG8iRQoYVGFrZVByb21v" + "dGlvblJld2FyZENzUmVxEhYKDmJhc2VfYXZhdGFyX2lkGAggASgNEhEKCXBy" + "b21vdGlvbhgKIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakePromotionRewardCsReq), TakePromotionRewardCsReq.Parser, new string[2] { "BaseAvatarId", "Promotion" }, null, null, null, null)
		}));
	}
}
