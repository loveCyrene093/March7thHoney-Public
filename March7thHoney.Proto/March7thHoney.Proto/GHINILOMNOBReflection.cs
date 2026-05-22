using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GHINILOMNOBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GHINILOMNOBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHSElOSUxPTU5PQi5wcm90byI3CgtHSElOSUxPTU5PQhITCgtIQU5ORE1H" + "SEJFTxgEIAEoDRITCgtNSUhCQURFUEdJRBgGIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GHINILOMNOB), GHINILOMNOB.Parser, new string[2] { "HANNDMGHBEO", "MIHBADEPGID" }, null, null, null, null)
		}));
	}
}
