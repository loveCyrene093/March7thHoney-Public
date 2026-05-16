using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CDHDOBHPJOGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CDHDOBHPJOGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDREhET0JIUEpPRy5wcm90byI0CgtDREhET0JIUEpPRxITCgtDT09PRkZL" + "SURNQxgDIAEoDRIQCghncm91cF9pZBgOIAEoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CDHDOBHPJOG), CDHDOBHPJOG.Parser, new string[2] { "COOOFFKIDMC", "GroupId" }, null, null, null, null)
		}));
	}
}
