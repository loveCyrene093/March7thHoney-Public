using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MissionCustomValueSnapshotReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MissionCustomValueSnapshotReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBNaXNzaW9uQ3VzdG9tVmFsdWVTbmFwc2hvdC5wcm90byJDChpNaXNzaW9u" + "Q3VzdG9tVmFsdWVTbmFwc2hvdBIUCgxjdXN0b21fdmFsdWUYASABKA0SDwoH" + "bWN2X2tleRgCIAEoCUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MissionCustomValueSnapshot), MissionCustomValueSnapshot.Parser, new string[2] { "CustomValue", "McvKey" }, null, null, null, null)
		}));
	}
}
