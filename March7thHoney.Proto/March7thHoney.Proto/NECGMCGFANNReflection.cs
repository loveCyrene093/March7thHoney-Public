using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NECGMCGFANNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NECGMCGFANNReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFORUNHTUNHRkFOTi5wcm90byJMCgtORUNHTUNHRkFOThITCgtJTkFISUxB" + "SElJShgBIAEoCBITCgtMREhOUENJTUxDShgCIAEoCBITCgtGQ05HSE5QRkpM" + "ThgDIAEoCEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NECGMCGFANN), NECGMCGFANN.Parser, new string[3] { "INAHILAHIIJ", "LDHNPCIMLCJ", "FCNGHNPFJLN" }, null, null, null, null)
		}));
	}
}
