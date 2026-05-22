using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightUpgradeTypeTargetInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightUpgradeTypeTargetInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRHcmlkRmlnaHRVcGdyYWRlVHlwZVRhcmdldEluZm8ucHJvdG8iQwoeR3Jp" + "ZEZpZ2h0VXBncmFkZVR5cGVUYXJnZXRJbmZvEiEKGWRyZXNzX2VxdWlwbWVu" + "dF91bmlxdWVfaWQYASABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy" + "b3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightUpgradeTypeTargetInfo), GridFightUpgradeTypeTargetInfo.Parser, new string[1] { "DressEquipmentUniqueId" }, null, null, null, null)
		}));
	}
}
