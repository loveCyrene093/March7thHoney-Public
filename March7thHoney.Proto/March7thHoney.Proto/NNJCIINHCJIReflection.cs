using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NNJCIINHCJIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NNJCIINHCJIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOTkpDSUlOSENKSS5wcm90byINCgtOTkpDSUlOSENKSUIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NNJCIINHCJI), NNJCIINHCJI.Parser, null, null, null, null, null)
		}));
	}
}
