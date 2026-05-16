using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class UnlockPhoneThemeScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static UnlockPhoneThemeScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5VbmxvY2tQaG9uZVRoZW1lU2NOb3RpZnkucHJvdG8iLAoYVW5sb2NrUGhv" + "bmVUaGVtZVNjTm90aWZ5EhAKCHRoZW1lX2lkGAggASgNQhaqAhNNYXJjaDd0" + "aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(UnlockPhoneThemeScNotify), UnlockPhoneThemeScNotify.Parser, new string[1] { "ThemeId" }, null, null, null, null)
		}));
	}
}
