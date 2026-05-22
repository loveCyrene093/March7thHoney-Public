using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetNpcMessageGroupScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetNpcMessageGroupScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1HZXROcGNNZXNzYWdlR3JvdXBTY1JzcC5wcm90bxoSTWVzc2FnZUdyb3Vw" + "LnByb3RvIlUKF0dldE5wY01lc3NhZ2VHcm91cFNjUnNwEg8KB3JldGNvZGUY" + "ASABKA0SKQoSbWVzc2FnZV9ncm91cF9saXN0GAYgAygLMg0uTWVzc2FnZUdy" + "b3VwQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { MessageGroupReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetNpcMessageGroupScRsp), GetNpcMessageGroupScRsp.Parser, new string[2] { "Retcode", "MessageGroupList" }, null, null, null, null)
		}));
	}
}
