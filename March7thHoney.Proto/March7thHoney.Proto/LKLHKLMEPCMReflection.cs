using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LKLHKLMEPCMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LKLHKLMEPCMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFMS0xIS0xNRVBDTS5wcm90byIfCgtMS0xIS0xNRVBDTRIQCghjaGVzdF9p" + "ZBgPIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LKLHKLMEPCM), LKLHKLMEPCM.Parser, new string[1] { "ChestId" }, null, null, null, null)
		}));
	}
}
