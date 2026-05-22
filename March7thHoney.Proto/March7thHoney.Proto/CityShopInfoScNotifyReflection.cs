using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CityShopInfoScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CityShopInfoScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpDaXR5U2hvcEluZm9TY05vdGlmeS5wcm90byJfChRDaXR5U2hvcEluZm9T" + "Y05vdGlmeRIaChJ0YWtlbl9sZXZlbF9yZXdhcmQYBCABKAQSCwoDZXhwGAcg" + "ASgNEg0KBWxldmVsGAkgASgNEg8KB3Nob3BfaWQYCyABKA1CFqoCE01hcmNo" + "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CityShopInfoScNotify), CityShopInfoScNotify.Parser, new string[4] { "TakenLevelReward", "Exp", "Level", "ShopId" }, null, null, null, null)
		}));
	}
}
