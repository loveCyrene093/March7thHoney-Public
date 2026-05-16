using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FriendApplyInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FriendApplyInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVGcmllbmRBcHBseUluZm8ucHJvdG8aFlBsYXllclNpbXBsZUluZm8ucHJv" + "dG8iTQoPRnJpZW5kQXBwbHlJbmZvEhIKCmFwcGx5X3RpbWUYDSABKAMSJgoL" + "cGxheWVyX2luZm8YDiABKAsyES5QbGF5ZXJTaW1wbGVJbmZvQhaqAhNNYXJj" + "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { PlayerSimpleInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FriendApplyInfo), FriendApplyInfo.Parser, new string[2] { "ApplyTime", "PlayerInfo" }, null, null, null, null)
		}));
	}
}
