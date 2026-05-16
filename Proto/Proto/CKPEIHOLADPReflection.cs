using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CKPEIHOLADPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CKPEIHOLADPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDS1BFSUhPTEFEUC5wcm90byIxCgtDS1BFSUhPTEFEUBITCgtLQk1NR09K" + "S0FQRhgLIAEoDRINCgVsZXZlbBgPIAEoDUIWqgITTWFyY2g3dGhIb25leS5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CKPEIHOLADP), CKPEIHOLADP.Parser, new string[2] { "KBMMGOJKAPF", "Level" }, null, null, null, null)
		}));
	}
}
