using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BIAGLOKBBMIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BIAGLOKBBMIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCSUFHTE9LQkJNSS5wcm90byINCgtCSUFHTE9LQkJNSUIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BIAGLOKBBMI), BIAGLOKBBMI.Parser, null, null, null, null, null)
		}));
	}
}
