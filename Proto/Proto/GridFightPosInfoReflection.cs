using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightPosInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightPosInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZHcmlkRmlnaHRQb3NJbmZvLnByb3RvIjIKEEdyaWRGaWdodFBvc0luZm8S" + "CwoDcG9zGAEgASgNEhEKCXVuaXF1ZV9pZBgEIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightPosInfo), GridFightPosInfo.Parser, new string[2] { "Pos", "UniqueId" }, null, null, null, null)
		}));
	}
}
