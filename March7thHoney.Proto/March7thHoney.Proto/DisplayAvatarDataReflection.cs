using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DisplayAvatarDataReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DisplayAvatarDataReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdEaXNwbGF5QXZhdGFyRGF0YS5wcm90byIzChFEaXNwbGF5QXZhdGFyRGF0" + "YRILCgNwb3MYAiABKA0SEQoJYXZhdGFyX2lkGA4gASgNQhaqAhNNYXJjaDd0" + "aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DisplayAvatarData), DisplayAvatarData.Parser, new string[2] { "Pos", "AvatarId" }, null, null, null, null)
		}));
	}
}
