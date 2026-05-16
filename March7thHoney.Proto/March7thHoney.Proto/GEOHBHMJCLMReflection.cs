using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GEOHBHMJCLMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GEOHBHMJCLMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHRU9IQkhNSkNMTS5wcm90byIiCgtHRU9IQkhNSkNMTRITCgtFUERDR0pC" + "Sk9KTRgPIAMoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GEOHBHMJCLM), GEOHBHMJCLM.Parser, new string[1] { "EPDCGJBJOJM" }, null, null, null, null)
		}));
	}
}
