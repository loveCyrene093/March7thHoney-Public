using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DMNDJBPGEKGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DMNDJBPGEKGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFETU5ESkJQR0VLRy5wcm90byI3CgtETU5ESkJQR0VLRxITCgtIRUlIR0ZB" + "T0ZOSxgFIAEoDRITCgtLRE9JTkxHS01CSRgHIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DMNDJBPGEKG), DMNDJBPGEKG.Parser, new string[2] { "HEIHGFAOFNK", "KDOINLGKMBI" }, null, null, null, null)
		}));
	}
}
