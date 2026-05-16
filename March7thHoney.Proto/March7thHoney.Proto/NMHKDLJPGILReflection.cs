using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NMHKDLJPGILReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NMHKDLJPGILReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOTUhLRExKUEdJTC5wcm90byI0CgtOTUhLRExKUEdJTBIQCghncm91cF9p" + "ZBgJIAEoDRITCgtQQk9MTUJMS0RORBgKIAEoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NMHKDLJPGIL), NMHKDLJPGIL.Parser, new string[2] { "GroupId", "PBOLMBLKDND" }, null, null, null, null)
		}));
	}
}
