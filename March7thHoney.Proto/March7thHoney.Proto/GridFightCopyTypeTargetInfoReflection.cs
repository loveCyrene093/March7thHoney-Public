using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightCopyTypeTargetInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightCopyTypeTargetInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFHcmlkRmlnaHRDb3B5VHlwZVRhcmdldEluZm8ucHJvdG8iOwobR3JpZEZp" + "Z2h0Q29weVR5cGVUYXJnZXRJbmZvEhwKFGRyZXNzX3JvbGVfdW5pcXVlX2lk" + "GAkgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightCopyTypeTargetInfo), GridFightCopyTypeTargetInfo.Parser, new string[1] { "DressRoleUniqueId" }, null, null, null, null)
		}));
	}
}
