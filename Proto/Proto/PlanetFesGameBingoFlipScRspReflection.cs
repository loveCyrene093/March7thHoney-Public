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
		buffer[0] = "CiFQbGFuZXRGZXNHYW1lQmluZ29GbGlwU2NSc3AucHJvdG8aEUhMTENEQkxD";
		buffer[1] = "SVBLLnByb3RvInYKG1BsYW5ldEZlc0dhbWVCaW5nb0ZsaXBTY1JzcBITCgtO";
		buffer[2] = "QkZMQ05IRkVGTRgDIAEoDRITCgtKS0xGTU9ISUNNTxgEIAEoCBIcCgZyZXdh";
		buffer[3] = "cmQYCCABKAsyDC5ITExDREJMQ0lQSxIPCgdyZXRjb2RlGA4gASgNQhaqAhNN";
		buffer[4] = "YXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { HLLCDBLCIPKReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlanetFesGameBingoFlipScRsp), PlanetFesGameBingoFlipScRsp.Parser, new string[4] { "NBFLCNHFEFM", "JKLFMOHICMO", "Reward", "Retcode" }, null, null, null, null)
		}));
	}
}
