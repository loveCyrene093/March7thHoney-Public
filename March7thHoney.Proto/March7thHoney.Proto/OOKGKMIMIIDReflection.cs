using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OOKGKMIMIIDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OOKGKMIMIIDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPT0tHS01JTUlJRC5wcm90byI3CgtPT0tHS01JTUlJRBITCgtLQkZET1BO" + "T0RCTBgBIAEoDRITCgtLS0ZCTEpOTURGShgGIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OOKGKMIMIID), OOKGKMIMIID.Parser, new string[2] { "KBFDOPNODBL", "KKFBLJNMDFJ" }, null, null, null, null)
		}));
	}
}
