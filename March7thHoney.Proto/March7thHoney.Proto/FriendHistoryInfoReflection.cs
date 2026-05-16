using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FriendHistoryInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FriendHistoryInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdGcmllbmRIaXN0b3J5SW5mby5wcm90byJBChFGcmllbmRIaXN0b3J5SW5m" + "bxIUCgxjb250YWN0X3NpZGUYCiABKA0SFgoObGFzdF9zZW5kX3RpbWUYDSAB" + "KANCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FriendHistoryInfo), FriendHistoryInfo.Parser, new string[2] { "ContactSide", "LastSendTime" }, null, null, null, null)
		}));
	}
}
