using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetGachaCeilingScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetGachaCeilingScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpHZXRHYWNoYUNlaWxpbmdTY1JzcC5wcm90bxoSR2FjaGFDZWlsaW5nLnBy" + "b3RvImEKFEdldEdhY2hhQ2VpbGluZ1NjUnNwEhIKCmdhY2hhX3R5cGUYAiAB" + "KA0SDwoHcmV0Y29kZRgEIAEoDRIkCg1nYWNoYV9jZWlsaW5nGAUgASgLMg0u" + "R2FjaGFDZWlsaW5nQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { GachaCeilingReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetGachaCeilingScRsp), GetGachaCeilingScRsp.Parser, new string[3] { "GachaType", "Retcode", "GachaCeiling" }, null, null, null, null)
		}));
	}
}
