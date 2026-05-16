using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightRollTypeTargetInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightRollTypeTargetInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFHcmlkRmlnaHRSb2xsVHlwZVRhcmdldEluZm8ucHJvdG8iXgobR3JpZEZp" + "Z2h0Um9sbFR5cGVUYXJnZXRJbmZvEiEKGWRyZXNzX2VxdWlwbWVudF91bmlx" + "dWVfaWQYBCABKA0SHAoUZHJlc3Nfcm9sZV91bmlxdWVfaWQYByABKA1CFqoC" + "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightRollTypeTargetInfo), GridFightRollTypeTargetInfo.Parser, new string[2] { "DressEquipmentUniqueId", "DressRoleUniqueId" }, null, null, null, null)
		}));
	}
}
