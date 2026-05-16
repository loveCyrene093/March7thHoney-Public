using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetActivityScheduleConfigCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetActivityScheduleConfigCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRHZXRBY3Rpdml0eVNjaGVkdWxlQ29uZmlnQ3NSZXEucHJvdG8iIAoeR2V0" + "QWN0aXZpdHlTY2hlZHVsZUNvbmZpZ0NzUmVxQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetActivityScheduleConfigCsReq), GetActivityScheduleConfigCsReq.Parser, null, null, null, null, null)
		}));
	}
}
