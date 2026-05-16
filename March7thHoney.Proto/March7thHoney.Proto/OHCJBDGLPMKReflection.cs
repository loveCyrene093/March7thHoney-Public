using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OHCJBDGLPMKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OHCJBDGLPMKReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPSENKQkRHTFBNSy5wcm90byINCgtPSENKQkRHTFBNS0IWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OHCJBDGLPMK), OHCJBDGLPMK.Parser, null, null, null, null, null)
		}));
	}
}
