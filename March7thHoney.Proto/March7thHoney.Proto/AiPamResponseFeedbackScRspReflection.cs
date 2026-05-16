using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AiPamResponseFeedbackScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AiPamResponseFeedbackScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBBaVBhbVJlc3BvbnNlRmVlZGJhY2tTY1JzcC5wcm90byJXChpBaVBhbVJl" + "c3BvbnNlRmVlZGJhY2tTY1JzcBITCgtGRkdJQ0dMRExLRRgDIAEoCBIPCgdy" + "ZXRjb2RlGAcgASgNEhMKC0RIRUtEQUdKQkpCGA0gASgIQhaqAhNNYXJjaDd0" + "aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AiPamResponseFeedbackScRsp), AiPamResponseFeedbackScRsp.Parser, new string[3] { "FFGICGLDLKE", "Retcode", "DHEKDAGJBJB" }, null, null, null, null)
		}));
	}
}
