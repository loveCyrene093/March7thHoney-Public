using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MarblePvpDataUpdateScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MarblePvpDataUpdateScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFNYXJibGVQdnBEYXRhVXBkYXRlU2NOb3RpZnkucHJvdG8iLwobTWFyYmxl" + "UHZwRGF0YVVwZGF0ZVNjTm90aWZ5EhAKCHNjb3JlX2lkGAcgASgFQhaqAhNN" + "YXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MarblePvpDataUpdateScNotify), MarblePvpDataUpdateScNotify.Parser, new string[1] { "ScoreId" }, null, null, null, null)
		}));
	}
}
