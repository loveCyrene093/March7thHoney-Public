using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OJAEEMPKCBNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OJAEEMPKCBNReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPSkFFRU1QS0NCTi5wcm90byIiCgtPSkFFRU1QS0NCThITCgtMQ0NHRkhK" + "S0tPQRgFIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OJAEEMPKCBN), OJAEEMPKCBN.Parser, new string[1] { "LCCGFHJKKOA" }, null, null, null, null)
		}));
	}
}
