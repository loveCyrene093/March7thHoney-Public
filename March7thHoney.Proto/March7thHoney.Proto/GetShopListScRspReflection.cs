using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetShopListScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetShopListScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZHZXRTaG9wTGlzdFNjUnNwLnByb3RvGgpTaG9wLnByb3RvIlAKEEdldFNo" + "b3BMaXN0U2NSc3ASDwoHcmV0Y29kZRgBIAEoDRIRCglzaG9wX3R5cGUYAyAB" + "KA0SGAoJc2hvcF9saXN0GA8gAygLMgUuU2hvcEIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { ShopReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetShopListScRsp), GetShopListScRsp.Parser, new string[3] { "Retcode", "ShopType", "ShopList" }, null, null, null, null)
		}));
	}
}
