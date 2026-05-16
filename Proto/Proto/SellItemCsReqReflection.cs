using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SellItemCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SellItemCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChNTZWxsSXRlbUNzUmVxLnByb3RvGhJJdGVtQ29zdERhdGEucHJvdG8iRQoN" + "U2VsbEl0ZW1Dc1JlcRISCgpUb01hdGVyaWFsGAogASgIEiAKCWNvc3RfZGF0" + "YRgOIAEoCzINLkl0ZW1Db3N0RGF0YUIWqgITTWFyY2g3dGhIb25leS5Qcm90" + "b2IGcHJvdG8z"), new FileDescriptor[1] { ItemCostDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SellItemCsReq), SellItemCsReq.Parser, new string[2] { "ToMaterial", "CostData" }, null, null, null, null)
		}));
	}
}
