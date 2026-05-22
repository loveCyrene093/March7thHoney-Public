using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IDEBDGICHAJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IDEBDGICHAJReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJREVCREdJQ0hBSi5wcm90byIiCgtJREVCREdJQ0hBShITCgtPT0NQQkpM" + "QlBESBgPIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IDEBDGICHAJ), IDEBDGICHAJ.Parser, new string[1] { "OOCPBJLBPDH" }, null, null, null, null)
		}));
	}
}
