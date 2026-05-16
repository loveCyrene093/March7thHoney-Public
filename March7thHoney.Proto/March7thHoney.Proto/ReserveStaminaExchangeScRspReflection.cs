using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ReserveStaminaExchangeScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ReserveStaminaExchangeScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFSZXNlcnZlU3RhbWluYUV4Y2hhbmdlU2NSc3AucHJvdG8iOwobUmVzZXJ2" + "ZVN0YW1pbmFFeGNoYW5nZVNjUnNwEgsKA251bRgDIAEoDRIPCgdyZXRjb2Rl" + "GAYgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ReserveStaminaExchangeScRsp), ReserveStaminaExchangeScRsp.Parser, new string[2] { "Num", "Retcode" }, null, null, null, null)
		}));
	}
}
