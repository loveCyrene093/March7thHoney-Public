using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SyncDeleteFriendScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SyncDeleteFriendScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5TeW5jRGVsZXRlRnJpZW5kU2NOb3RpZnkucHJvdG8iJwoYU3luY0RlbGV0" + "ZUZyaWVuZFNjTm90aWZ5EgsKA3VpZBgJIAEoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SyncDeleteFriendScNotify), SyncDeleteFriendScNotify.Parser, new string[1] { "Uid" }, null, null, null, null)
		}));
	}
}
