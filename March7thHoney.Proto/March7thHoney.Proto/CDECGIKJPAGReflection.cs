using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CDECGIKJPAGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CDECGIKJPAGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDREVDR0lLSlBBRy5wcm90byIuCgtDREVDR0lLSlBBRxIPCgdyb2xlX2lk" + "GAEgASgNEg4KBmRhbWFnZRgCIAEoAUIWqgITTWFyY2g3dGhIb25leS5Qcm90" + "b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CDECGIKJPAG), CDECGIKJPAG.Parser, new string[2] { "RoleId", "Damage" }, null, null, null, null)
		}));
	}
}
