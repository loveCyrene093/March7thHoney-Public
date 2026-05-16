using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KILNLEDAHOCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KILNLEDAHOCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLSUxOTEVEQUhPQy5wcm90byI3CgtLSUxOTEVEQUhPQxITCgtBSVBJSEpM" + "Q0lIQRgFIAEoDRITCgtIRUlIR0ZBT0ZOSxgNIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KILNLEDAHOC), KILNLEDAHOC.Parser, new string[2] { "AIPIHJLCIHA", "HEIHGFAOFNK" }, null, null, null, null)
		}));
	}
}
