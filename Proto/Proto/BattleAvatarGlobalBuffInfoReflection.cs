using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BattleAvatarGlobalBuffInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BattleAvatarGlobalBuffInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBCYXR0bGVBdmF0YXJHbG9iYWxCdWZmSW5mby5wcm90byJaChpCYXR0bGVB" + "dmF0YXJHbG9iYWxCdWZmSW5mbxIRCglhdmF0YXJfaWQYASABKA0SFAoMbWF6" + "ZV9idWZmX2lkGAIgASgNEhMKC0lMQk1GQUtGREtJGAMgASgNQhaqAhNNYXJj" + "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BattleAvatarGlobalBuffInfo), BattleAvatarGlobalBuffInfo.Parser, new string[3] { "AvatarId", "MazeBuffId", "ILBMFAKFDKI" }, null, null, null, null)
		}));
	}
}
