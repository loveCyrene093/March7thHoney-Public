using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MDNIEJENNIIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MDNIEJENNIIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNRE5JRUpFTk5JSS5wcm90byIiCgtNRE5JRUpFTk5JSRITCgtLUEpHRUdN" + "Q0NBRxgNIAMoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MDNIEJENNII), MDNIEJENNII.Parser, new string[1] { "KPJGEGMCCAG" }, null, null, null, null)
		}));
	}
}
