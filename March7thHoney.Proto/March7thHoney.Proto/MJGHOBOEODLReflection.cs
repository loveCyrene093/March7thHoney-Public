using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MJGHOBOEODLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MJGHOBOEODLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNSkdIT0JPRU9ETC5wcm90byI3CgtNSkdIT0JPRU9ETBITCgtNREdLSkVC" + "Q0tGUBgEIAEoDRITCgtMQk9CTlBPQk5FSxgIIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MJGHOBOEODL), MJGHOBOEODL.Parser, new string[2] { "MDGKJEBCKFP", "LBOBNPOBNEK" }, null, null, null, null)
		}));
	}
}
