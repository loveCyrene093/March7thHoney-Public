using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ElfRestaurantBuyShopItemCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ElfRestaurantBuyShopItemCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNFbGZSZXN0YXVyYW50QnV5U2hvcEl0ZW1Dc1JlcS5wcm90byJJCh1FbGZS" + "ZXN0YXVyYW50QnV5U2hvcEl0ZW1Dc1JlcRITCgtOR0JOSVBFTUhNRBgBIAEo" + "DRITCgtNT0tCSlBHQkdBQhgPIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90" + "b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ElfRestaurantBuyShopItemCsReq), ElfRestaurantBuyShopItemCsReq.Parser, new string[2] { "NGBNIPEMHMD", "MOKBJPGBGAB" }, null, null, null, null)
		}));
	}
}
