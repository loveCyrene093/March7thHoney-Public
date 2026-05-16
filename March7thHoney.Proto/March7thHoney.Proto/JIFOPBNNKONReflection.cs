using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JIFOPBNNKONReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JIFOPBNNKONReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKSUZPUEJOTktPTi5wcm90byIiCgtKSUZPUEJOTktPThITCgtPR09OSk9H" + "RERJRRgOIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JIFOPBNNKON), JIFOPBNNKON.Parser, new string[1] { "OGONJOGDDIE" }, null, null, null, null)
		}));
	}
}
