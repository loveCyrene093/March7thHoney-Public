using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LockRelicScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LockRelicScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRMb2NrUmVsaWNTY1JzcC5wcm90byIhCg5Mb2NrUmVsaWNTY1JzcBIPCgdy" + "ZXRjb2RlGAcgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LockRelicScRsp), LockRelicScRsp.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
