using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PGJKONMBGOCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PGJKONMBGOCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQR0pLT05NQkdPQy5wcm90byIlCgtQR0pLT05NQkdPQxIWCg5wb3J0YWxf" + "YnVmZl9pZBgBIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PGJKONMBGOC), PGJKONMBGOC.Parser, new string[1] { "PortalBuffId" }, null, null, null, null)
		}));
	}
}
