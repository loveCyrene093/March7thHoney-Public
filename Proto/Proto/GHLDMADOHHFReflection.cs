using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GHLDMADOHHFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GHLDMADOHHFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHSExETUFET0hIRi5wcm90byIuCgtHSExETUFET0hIRhIQCghza2lsbF9p" + "ZBgGIAEoDRINCgVsZXZlbBgJIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90" + "b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GHLDMADOHHF), GHLDMADOHHF.Parser, new string[2] { "SkillId", "Level" }, null, null, null, null)
		}));
	}
}
