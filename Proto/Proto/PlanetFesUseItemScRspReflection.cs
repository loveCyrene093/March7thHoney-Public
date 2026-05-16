using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlanetFesUseItemScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlanetFesUseItemScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtQbGFuZXRGZXNVc2VJdGVtU2NSc3AucHJvdG8aEUhMTENEQkxDSVBLLnBy" + "b3RvIkYKFVBsYW5ldEZlc1VzZUl0ZW1TY1JzcBIcCgZyZXdhcmQYAyABKAsy" + "DC5ITExDREJMQ0lQSxIPCgdyZXRjb2RlGAwgASgNQhaqAhNNYXJjaDd0aEhv" + "bmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { HLLCDBLCIPKReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlanetFesUseItemScRsp), PlanetFesUseItemScRsp.Parser, new string[2] { "Reward", "Retcode" }, null, null, null, null)
		}));
	}
}
