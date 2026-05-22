using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GGFDCHANNEBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GGFDCHANNEBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHR0ZEQ0hBTk5FQi5wcm90bxoSSXRlbUNvc3REYXRhLnByb3RvIlkKC0dH" + "RkRDSEFOTkVCEiAKCWNvc3RfZGF0YRgBIAEoCzINLkl0ZW1Db3N0RGF0YRIT" + "CgtQSUdESUZBS0lHTRgIIAEoBRITCgtKS0lNTElQTUtGSBgMIAEoDUIWqgIT" + "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { ItemCostDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GGFDCHANNEB), GGFDCHANNEB.Parser, new string[3] { "CostData", "PIGDIFAKIGM", "JKIMLIPMKFH" }, null, null, null, null)
		}));
	}
}
