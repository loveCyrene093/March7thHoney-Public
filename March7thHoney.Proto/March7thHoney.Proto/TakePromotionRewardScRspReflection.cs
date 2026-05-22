using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakePromotionRewardScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakePromotionRewardScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5UYWtlUHJvbW90aW9uUmV3YXJkU2NSc3AucHJvdG8aDkl0ZW1MaXN0LnBy" + "b3RvIksKGFRha2VQcm9tb3Rpb25SZXdhcmRTY1JzcBIeCgtyZXdhcmRfbGlz" + "dBgBIAEoCzIJLkl0ZW1MaXN0Eg8KB3JldGNvZGUYBSABKA1CFqoCE01hcmNo" + "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakePromotionRewardScRsp), TakePromotionRewardScRsp.Parser, new string[2] { "RewardList", "Retcode" }, null, null, null, null)
		}));
	}
}
