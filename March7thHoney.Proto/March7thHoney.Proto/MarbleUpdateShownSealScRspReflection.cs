using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MarbleUpdateShownSealScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MarbleUpdateShownSealScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBNYXJibGVVcGRhdGVTaG93blNlYWxTY1JzcC5wcm90byJCChpNYXJibGVV" + "cGRhdGVTaG93blNlYWxTY1JzcBIPCgdyZXRjb2RlGAUgASgNEhMKC0xBSU5B" + "RUFNSEpCGA4gAygNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MarbleUpdateShownSealScRsp), MarbleUpdateShownSealScRsp.Parser, new string[2] { "Retcode", "LAINAEAMHJB" }, null, null, null, null)
		}));
	}
}
