using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EEGAIOCCMKMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EEGAIOCCMKMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFRUdBSU9DQ01LTS5wcm90byIZCgtFRUdBSU9DQ01LTRIKCgJpZBgEIAEo" + "DUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EEGAIOCCMKM), EEGAIOCCMKM.Parser, new string[1] { "Id" }, null, null, null, null)
		}));
	}
}
