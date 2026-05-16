using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class UnlockAvatarSkinScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static UnlockAvatarSkinScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5VbmxvY2tBdmF0YXJTa2luU2NOb3RpZnkucHJvdG8iKwoYVW5sb2NrQXZh" + "dGFyU2tpblNjTm90aWZ5Eg8KB3NraW5faWQYAyABKA1CFqoCE01hcmNoN3Ro" + "SG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(UnlockAvatarSkinScNotify), UnlockAvatarSkinScNotify.Parser, new string[1] { "SkinId" }, null, null, null, null)
		}));
	}
}
