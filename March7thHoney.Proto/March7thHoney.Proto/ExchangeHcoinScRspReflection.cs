using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ExchangeHcoinScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ExchangeHcoinScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhFeGNoYW5nZUhjb2luU2NSc3AucHJvdG8iMgoSRXhjaGFuZ2VIY29pblNj" + "UnNwEgsKA251bRgKIAEoDRIPCgdyZXRjb2RlGAsgASgNQhaqAhNNYXJjaDd0" + "aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ExchangeHcoinScRsp), ExchangeHcoinScRsp.Parser, new string[2] { "Num", "Retcode" }, null, null, null, null)
		}));
	}
}
