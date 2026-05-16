using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DailyRefreshNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DailyRefreshNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhEYWlseVJlZnJlc2hOb3RpZnkucHJvdG8iKQoSRGFpbHlSZWZyZXNoTm90" + "aWZ5EhMKC0tBQUdIQVBHTENQGAcgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlBy" + "b3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DailyRefreshNotify), DailyRefreshNotify.Parser, new string[1] { "KAAGHAPGLCP" }, null, null, null, null)
		}));
	}
}
