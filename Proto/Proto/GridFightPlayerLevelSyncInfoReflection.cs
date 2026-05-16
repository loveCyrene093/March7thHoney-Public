using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightPlayerLevelSyncInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightPlayerLevelSyncInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJHcmlkRmlnaHRQbGF5ZXJMZXZlbFN5bmNJbmZvLnByb3RvIk0KHEdyaWRG" + "aWdodFBsYXllckxldmVsU3luY0luZm8SCwoDZXhwGAEgASgNEg0KBWxldmVs" + "GAQgASgNEhEKCW1heF9sZXZlbBgMIAEoDUIWqgITTWFyY2g3dGhIb25leS5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightPlayerLevelSyncInfo), GridFightPlayerLevelSyncInfo.Parser, new string[3] { "Exp", "Level", "MaxLevel" }, null, null, null, null)
		}));
	}
}
