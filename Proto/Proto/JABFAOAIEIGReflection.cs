using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JABFAOAIEIGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JABFAOAIEIGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKQUJGQU9BSUVJRy5wcm90byI3CgtKQUJGQU9BSUVJRxITCgtOT0tCS0FJ" + "T0tGRRgIIAEoDRITCgtDTkRLQVBPSUVPShgKIAEoCEIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JABFAOAIEIG), JABFAOAIEIG.Parser, new string[2] { "NOKBKAIOKFE", "CNDKAPOIEOJ" }, null, null, null, null)
		}));
	}
}
