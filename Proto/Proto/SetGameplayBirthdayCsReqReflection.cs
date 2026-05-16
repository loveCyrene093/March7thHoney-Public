using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetGameplayBirthdayCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetGameplayBirthdayCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5TZXRHYW1lcGxheUJpcnRoZGF5Q3NSZXEucHJvdG8iLAoYU2V0R2FtZXBs" + "YXlCaXJ0aGRheUNzUmVxEhAKCGJpcnRoZGF5GAQgASgNQhaqAhNNYXJjaDd0" + "aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetGameplayBirthdayCsReq), SetGameplayBirthdayCsReq.Parser, new string[1] { "Birthday" }, null, null, null, null)
		}));
	}
}
