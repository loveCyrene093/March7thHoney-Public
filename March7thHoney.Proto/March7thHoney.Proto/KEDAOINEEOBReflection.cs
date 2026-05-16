using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KEDAOINEEOBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KEDAOINEEOBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLRURBT0lORUVPQi5wcm90byI3CgtLRURBT0lORUVPQhITCgtGTEJGQkJK" + "SUpJSRgDIAEoCRITCgtITkhJR0hHS0VDThgNIAEoCUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KEDAOINEEOB), KEDAOINEEOB.Parser, new string[2] { "FLBFBBJIJII", "HNHIGHGKECN" }, null, null, null, null)
		}));
	}
}
