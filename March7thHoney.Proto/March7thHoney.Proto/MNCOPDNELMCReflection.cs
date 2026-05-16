using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MNCOPDNELMCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MNCOPDNELMCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNTkNPUERORUxNQy5wcm90bxoRRE9JSk5DTEpHS08ucHJvdG8iMAoLTU5D" + "T1BETkVMTUMSIQoLUEhQT0xITEpHRk0YAyADKAsyDC5ET0lKTkNMSkdLT0IW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { DOIJNCLJGKOReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MNCOPDNELMC), MNCOPDNELMC.Parser, new string[1] { "PHPOLHLJGFM" }, null, null, null, null)
		}));
	}
}
