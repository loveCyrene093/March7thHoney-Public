using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DiceCombatAvatarReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DiceCombatAvatarReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZEaWNlQ29tYmF0QXZhdGFyLnByb3RvImQKEERpY2VDb21iYXRBdmF0YXIS" + "FgoOZGljZV9hdmF0YXJfaWQYASABKA0SDQoFbGV2ZWwYAiABKA0SFAoMZGlj" + "ZV9pZF9saXN0GAMgAygNEhMKC3VubG9ja190aW1lGAQgASgDQhaqAhNNYXJj" + "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DiceCombatAvatar), DiceCombatAvatar.Parser, new string[4] { "DiceAvatarId", "Level", "DiceIdList", "UnlockTime" }, null, null, null, null)
		}));
	}
}
