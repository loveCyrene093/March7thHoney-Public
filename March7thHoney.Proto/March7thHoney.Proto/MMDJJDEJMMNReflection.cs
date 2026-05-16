using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MMDJJDEJMMNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MMDJJDEJMMNReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNTURKSkRFSk1NTi5wcm90byIlCgtNTURKSkRFSk1NThIWCg5wb3J0YWxf" + "YnVmZl9pZBgBIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MMDJJDEJMMN), MMDJJDEJMMN.Parser, new string[1] { "PortalBuffId" }, null, null, null, null)
		}));
	}
}
