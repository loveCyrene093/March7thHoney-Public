using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CCGMLKGIDGCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CCGMLKGIDGCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDQ0dNTEtHSURHQy5wcm90byI3CgtDQ0dNTEtHSURHQxITCgtHS09MTk5L" + "SE5HUBgBIAEoDRITCgtHS0pBQ0xGQkpLRBgCIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CCGMLKGIDGC), CCGMLKGIDGC.Parser, new string[2] { "GKOLNNKHNGP", "GKJACLFBJKD" }, null, null, null, null)
		}));
	}
}
