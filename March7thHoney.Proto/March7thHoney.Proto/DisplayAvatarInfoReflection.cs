using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DisplayAvatarInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DisplayAvatarInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdEaXNwbGF5QXZhdGFySW5mby5wcm90byI7ChFEaXNwbGF5QXZhdGFySW5m" + "bxITCgtDQkhLRk9FT01GRhgLIAEoDRIRCglhdmF0YXJfaWQYDyABKA1CFqoC" + "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DisplayAvatarInfo), DisplayAvatarInfo.Parser, new string[2] { "CBHKFOEOMFF", "AvatarId" }, null, null, null, null)
		}));
	}
}
