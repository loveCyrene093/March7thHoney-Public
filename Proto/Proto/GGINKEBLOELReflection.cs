using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GGINKEBLOELReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GGINKEBLOELReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHR0lOS0VCTE9FTC5wcm90byI0CgtHR0lOS0VCTE9FTBIQCghwcm9ncmVz" + "cxgLIAEoDRITCgtLTUVNS01QTUZISBgNIAEoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GGINKEBLOEL), GGINKEBLOEL.Parser, new string[2] { "Progress", "KMEMKMPMFHH" }, null, null, null, null)
		}));
	}
}
