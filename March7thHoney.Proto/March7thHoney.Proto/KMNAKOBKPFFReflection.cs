using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KMNAKOBKPFFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KMNAKOBKPFFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLTU5BS09CS1BGRi5wcm90byI0CgtLTU5BS09CS1BGRhIQCgh0cmFpdF9p" + "ZBgIIAEoDRITCgtLSU5JS0ZDS0dERhgJIAEoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KMNAKOBKPFF), KMNAKOBKPFF.Parser, new string[2] { "TraitId", "KINIKFCKGDF" }, null, null, null, null)
		}));
	}
}
