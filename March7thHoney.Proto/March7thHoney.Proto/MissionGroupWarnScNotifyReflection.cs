using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MissionGroupWarnScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MissionGroupWarnScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5NaXNzaW9uR3JvdXBXYXJuU2NOb3RpZnkucHJvdG8iLwoYTWlzc2lvbkdy" + "b3VwV2FyblNjTm90aWZ5EhMKC0xHRUVQTEdCQU9NGA8gAygNQhaqAhNNYXJj" + "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MissionGroupWarnScNotify), MissionGroupWarnScNotify.Parser, new string[1] { "LGEEPLGBAOM" }, null, null, null, null)
		}));
	}
}
