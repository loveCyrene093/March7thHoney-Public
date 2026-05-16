using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ExpUpRelicCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ExpUpRelicCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVFeHBVcFJlbGljQ3NSZXEucHJvdG8aEkl0ZW1Db3N0RGF0YS5wcm90byJM" + "Cg9FeHBVcFJlbGljQ3NSZXESFwoPcmVsaWNfdW5pcXVlX2lkGAEgASgNEiAK" + "CWNvc3RfZGF0YRgCIAEoCzINLkl0ZW1Db3N0RGF0YUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { ItemCostDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ExpUpRelicCsReq), ExpUpRelicCsReq.Parser, new string[2] { "RelicUniqueId", "CostData" }, null, null, null, null)
		}));
	}
}
