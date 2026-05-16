using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EndDungeonScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EndDungeonScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVFbmREdW5nZW9uU2NSc3AucHJvdG8aDkl0ZW1MaXN0LnByb3RvImcKD0Vu" + "ZER1bmdlb25TY1JzcBIPCgdyZXRjb2RlGAIgASgNEhMKC3RhcmdldF9zaWRl" + "GAQgASgNEhkKBnJld2FyZBgKIAEoCzIJLkl0ZW1MaXN0EhMKC0JITU1NSEJG" + "SE9MGA4gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EndDungeonScRsp), EndDungeonScRsp.Parser, new string[4] { "Retcode", "TargetSide", "Reward", "BHMMMHBFHOL" }, null, null, null, null)
		}));
	}
}
