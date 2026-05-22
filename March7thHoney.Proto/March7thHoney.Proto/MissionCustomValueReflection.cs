using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MissionCustomValueReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MissionCustomValueReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhNaXNzaW9uQ3VzdG9tVmFsdWUucHJvdG8iTgoSTWlzc2lvbkN1c3RvbVZh" + "bHVlEhQKDGN1c3RvbV92YWx1ZRgEIAEoDRITCgtETENMRElBT0lNSxgOIAEo" + "CRINCgVpbmRleBgPIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv" + "dG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MissionCustomValue), MissionCustomValue.Parser, new string[3] { "CustomValue", "DLCLDIAOIMK", "Index" }, null, null, null, null)
		}));
	}
}
