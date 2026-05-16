using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JAFPMLLOGDIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JAFPMLLOGDIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKQUZQTUxMT0dESS5wcm90byJJCgtKQUZQTUxMT0dESRITCgtNT09PUEFN" + "Qk9GSxgMIAEoDRITCgtza2lsbF9sZXZlbBgOIAEoDRIQCghza2lsbF9pZBgP" + "IAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JAFPMLLOGDI), JAFPMLLOGDI.Parser, new string[3] { "MOOOPAMBOFK", "SkillLevel", "SkillId" }, null, null, null, null)
		}));
	}
}
