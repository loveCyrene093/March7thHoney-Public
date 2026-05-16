using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IFDFHPAMHCLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IFDFHPAMHCLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJRkRGSFBBTUhDTC5wcm90byIiCgtJRkRGSFBBTUhDTBITCgtLS01CTENK" + "SEFISxgBIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IFDFHPAMHCL), IFDFHPAMHCL.Parser, new string[1] { "KKMBLCJHAHK" }, null, null, null, null)
		}));
	}
}
