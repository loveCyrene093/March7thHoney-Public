using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CPIOCHHPICDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CPIOCHHPICDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDUElPQ0hIUElDRC5wcm90bxoRRkJCTURGRE9FRUYucHJvdG8aEUZJR0ZE" + "TkJJSENGLnByb3RvIlMKC0NQSU9DSEhQSUNEEiEKC0JJS0hPRUdGRUZEGAMg" + "ASgLMgwuRkJCTURGRE9FRUYSIQoLTEVLTEtOS0VCUE8YDiABKAsyDC5GSUdG" + "RE5CSUhDRkIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[2]
		{
			FBBMDFDOEEFReflection.Descriptor,
			FIGFDNBIHCFReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CPIOCHHPICD), CPIOCHHPICD.Parser, new string[2] { "BIKHOEGFEFD", "LEKLKNKEBPO" }, null, null, null, null)
		}));
	}
}
