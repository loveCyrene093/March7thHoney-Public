using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetPlayerOutfitScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetPlayerOutfitScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpTZXRQbGF5ZXJPdXRmaXRTY1JzcC5wcm90byInChRTZXRQbGF5ZXJPdXRm" + "aXRTY1JzcBIPCgdyZXRjb2RlGA4gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlBy" + "b3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetPlayerOutfitScRsp), SetPlayerOutfitScRsp.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
