using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlanetFesGameBingoFlipScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlanetFesGameBingoFlipScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CiFQbGFuZXRGZXNHYW1lQmluZ29GbGlwU2NSc3AucHJvdG8aEUhMTENEQkxD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "SVBLLnByb3RvInYKG1BsYW5ldEZlc0dhbWVCaW5nb0ZsaXBTY1JzcBITCgtO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "QkZMQ05IRkVGTRgDIAEoDRITCgtKS0xGTU9ISUNNTxgEIAEoCBIcCgZyZXdh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "cmQYCCABKAsyDC5ITExDREJMQ0lQSxIPCgdyZXRjb2RlGA4gASgNQhaqAhNN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "YXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { HLLCDBLCIPKReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlanetFesGameBingoFlipScRsp), PlanetFesGameBingoFlipScRsp.Parser, new string[4] { "NBFLCNHFEFM", "JKLFMOHICMO", "Reward", "Retcode" }, null, null, null, null)
		}));
	}
}
