using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetNpcStatusScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetNpcStatusScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdHZXROcGNTdGF0dXNTY1JzcC5wcm90bxoPTnBjU3RhdHVzLnByb3RvIkkK" + "EUdldE5wY1N0YXR1c1NjUnNwEg8KB3JldGNvZGUYASABKA0SIwoPbnBjX3N0" + "YXR1c19saXN0GAkgAygLMgouTnBjU3RhdHVzQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { NpcStatusReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetNpcStatusScRsp), GetNpcStatusScRsp.Parser, new string[2] { "Retcode", "NpcStatusList" }, null, null, null, null)
		}));
	}
}
