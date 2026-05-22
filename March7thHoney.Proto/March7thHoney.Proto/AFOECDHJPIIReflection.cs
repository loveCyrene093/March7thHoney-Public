using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AFOECDHJPIIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AFOECDHJPIIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBRk9FQ0RISlBJSS5wcm90bxoRR09GRkxHRUpFTkQucHJvdG8aEUlNSE5C" + "TU9NTEFDLnByb3RvIlMKC0FGT0VDREhKUElJEiEKC0pKR01QRkdDS0hHGAMg" + "AygLMgwuR09GRkxHRUpFTkQSIQoLSE1MQVBMS0VEREgYCSADKAsyDC5JTUhO" + "Qk1PTUxBQ0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[2]
		{
			GOFFLGEJENDReflection.Descriptor,
			IMHNBMOMLACReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AFOECDHJPII), AFOECDHJPII.Parser, new string[2] { "JJGMPFGCKHG", "HMLAPLKEDDH" }, null, null, null, null)
		}));
	}
}
