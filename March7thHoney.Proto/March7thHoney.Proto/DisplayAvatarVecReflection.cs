using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DisplayAvatarVecReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DisplayAvatarVecReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZEaXNwbGF5QXZhdGFyVmVjLnByb3RvGhdEaXNwbGF5QXZhdGFyRGF0YS5w" + "cm90byJXChBEaXNwbGF5QXZhdGFyVmVjEhIKCmlzX2Rpc3BsYXkYASABKAgS" + "LwoTZGlzcGxheV9hdmF0YXJfbGlzdBgHIAMoCzISLkRpc3BsYXlBdmF0YXJE" + "YXRhQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { DisplayAvatarDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DisplayAvatarVec), DisplayAvatarVec.Parser, new string[2] { "IsDisplay", "DisplayAvatarList" }, null, null, null, null)
		}));
	}
}
