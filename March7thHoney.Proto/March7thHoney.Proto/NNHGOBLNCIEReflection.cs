using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NNHGOBLNCIEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NNHGOBLNCIEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOTkhHT0JMTkNJRS5wcm90byJMCgtOTkhHT0JMTkNJRRITCgtFTEtPQ0lK" + "TkFCSxgEIAEoBRITCgtFTE5DSkZGSkZJSBgIIAEoCRITCgtGTkFPRE5HSkFN" + "TRgLIAEoBUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NNHGOBLNCIE), NNHGOBLNCIE.Parser, new string[3] { "ELKOCIJNABK", "ELNCJFFJFIH", "FNAODNGJAMM" }, null, null, null, null)
		}));
	}
}
