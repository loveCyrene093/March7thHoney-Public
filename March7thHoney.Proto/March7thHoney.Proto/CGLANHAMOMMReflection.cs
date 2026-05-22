using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CGLANHAMOMMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CGLANHAMOMMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDR0xBTkhBTU9NTS5wcm90byJDCgtDR0xBTkhBTU9NTRITCgtNT09PUEFN" + "Qk9GSxgDIAEoDRINCgVsZXZlbBgHIAEoDRIQCghza2lsbF9pZBgNIAEoDUIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CGLANHAMOMM), CGLANHAMOMM.Parser, new string[3] { "MOOOPAMBOFK", "Level", "SkillId" }, null, null, null, null)
		}));
	}
}
