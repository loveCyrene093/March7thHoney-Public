using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EDCFBOMKLLPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EDCFBOMKLLPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFRENGQk9NS0xMUC5wcm90byIiCgtFRENGQk9NS0xMUBITCgtBRUhOTk5B" + "SURBTBgJIAMoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EDCFBOMKLLP), EDCFBOMKLLP.Parser, new string[1] { "AEHNNNAIDAL" }, null, null, null, null)
		}));
	}
}
