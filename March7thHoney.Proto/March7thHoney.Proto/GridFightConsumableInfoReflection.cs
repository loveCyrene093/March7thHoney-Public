using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightConsumableInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightConsumableInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1HcmlkRmlnaHRDb25zdW1hYmxlSW5mby5wcm90byI3ChdHcmlkRmlnaHRD" + "b25zdW1hYmxlSW5mbxILCgNudW0YAiABKA0SDwoHaXRlbV9pZBgOIAEoDUIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightConsumableInfo), GridFightConsumableInfo.Parser, new string[2] { "Num", "ItemId" }, null, null, null, null)
		}));
	}
}
