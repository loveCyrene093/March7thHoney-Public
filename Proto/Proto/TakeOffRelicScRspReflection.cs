using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeOffRelicScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeOffRelicScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdUYWtlT2ZmUmVsaWNTY1JzcC5wcm90byIkChFUYWtlT2ZmUmVsaWNTY1Jz" + "cBIPCgdyZXRjb2RlGAMgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw" + "cm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeOffRelicScRsp), TakeOffRelicScRsp.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
