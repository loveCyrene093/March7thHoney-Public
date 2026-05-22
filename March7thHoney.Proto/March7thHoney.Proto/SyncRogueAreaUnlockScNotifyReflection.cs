using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SyncRogueAreaUnlockScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SyncRogueAreaUnlockScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFTeW5jUm9ndWVBcmVhVW5sb2NrU2NOb3RpZnkucHJvdG8iLgobU3luY1Jv" + "Z3VlQXJlYVVubG9ja1NjTm90aWZ5Eg8KB2FyZWFfaWQYASABKA1CFqoCE01h" + "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SyncRogueAreaUnlockScNotify), SyncRogueAreaUnlockScNotify.Parser, new string[1] { "AreaId" }, null, null, null, null)
		}));
	}
}
