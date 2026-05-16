using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SyncAddBlacklistScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SyncAddBlacklistScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5TeW5jQWRkQmxhY2tsaXN0U2NOb3RpZnkucHJvdG8iJwoYU3luY0FkZEJs" + "YWNrbGlzdFNjTm90aWZ5EgsKA3VpZBgIIAEoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SyncAddBlacklistScNotify), SyncAddBlacklistScNotify.Parser, new string[1] { "Uid" }, null, null, null, null)
		}));
	}
}
