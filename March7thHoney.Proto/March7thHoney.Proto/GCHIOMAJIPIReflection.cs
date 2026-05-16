using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GCHIOMAJIPIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GCHIOMAJIPIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHQ0hJT01BSklQSS5wcm90byIiCgtHQ0hJT01BSklQSRITCgtERE1LQ09C" + "T01OTxgGIAMoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GCHIOMAJIPI), GCHIOMAJIPI.Parser, new string[1] { "DDMKCOBOMNO" }, null, null, null, null)
		}));
	}
}
