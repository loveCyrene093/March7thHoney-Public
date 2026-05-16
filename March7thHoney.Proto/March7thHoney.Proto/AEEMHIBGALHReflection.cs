using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AEEMHIBGALHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AEEMHIBGALHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBRUVNSElCR0FMSC5wcm90bxoSSXRlbUNvc3REYXRhLnByb3RvIlkKC0FF" + "RU1ISUJHQUxIEiAKCWNvc3RfZGF0YRgDIAEoCzINLkl0ZW1Db3N0RGF0YRIT" + "CgtQSUdESUZBS0lHTRgGIAEoBRITCgtKS0lNTElQTUtGSBgNIAEoDUIWqgIT" + "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { ItemCostDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AEEMHIBGALH), AEEMHIBGALH.Parser, new string[3] { "CostData", "PIGDIFAKIGM", "JKIMLIPMKFH" }, null, null, null, null)
		}));
	}
}
