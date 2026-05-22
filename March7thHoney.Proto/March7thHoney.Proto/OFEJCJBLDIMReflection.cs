using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OFEJCJBLDIMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OFEJCJBLDIMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPRkVKQ0pCTERJTS5wcm90byIuCgtPRkVKQ0pCTERJTRIKCgJpZBgBIAEo" + "DRITCgtKS0NHQ0FNSUZJQRgCIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90" + "b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OFEJCJBLDIM), OFEJCJBLDIM.Parser, new string[2] { "Id", "JKCGCAMIFIA" }, null, null, null, null)
		}));
	}
}
