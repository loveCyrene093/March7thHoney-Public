using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DiceCombatUpgradeAvatarCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DiceCombatUpgradeAvatarCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJEaWNlQ29tYmF0VXBncmFkZUF2YXRhckNzUmVxLnByb3RvIjEKHERpY2VD" + "b21iYXRVcGdyYWRlQXZhdGFyQ3NSZXESEQoJYXZhdGFyX2lkGAEgASgNQhaq" + "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DiceCombatUpgradeAvatarCsReq), DiceCombatUpgradeAvatarCsReq.Parser, new string[1] { "AvatarId" }, null, null, null, null)
		}));
	}
}
