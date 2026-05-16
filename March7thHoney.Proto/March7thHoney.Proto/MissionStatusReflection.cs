using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MissionStatusReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MissionStatusReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChNNaXNzaW9uU3RhdHVzLnByb3RvKl4KDU1pc3Npb25TdGF0dXMSEAoMTUlT" + "U0lPTl9OT05FEAASEQoNTUlTU0lPTl9ET0lORxABEhIKDk1JU1NJT05fRklO" + "SVNIEAISFAoQTUlTU0lPTl9QUkVQQVJFRBADQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(MissionStatus) }, null, null));
	}
}
