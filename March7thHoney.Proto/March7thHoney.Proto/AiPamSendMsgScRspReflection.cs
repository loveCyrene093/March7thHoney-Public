using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AiPamSendMsgScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AiPamSendMsgScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdBaVBhbVNlbmRNc2dTY1JzcC5wcm90byIkChFBaVBhbVNlbmRNc2dTY1Jz" + "cBIPCgdyZXRjb2RlGAsgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw" + "cm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AiPamSendMsgScRsp), AiPamSendMsgScRsp.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
