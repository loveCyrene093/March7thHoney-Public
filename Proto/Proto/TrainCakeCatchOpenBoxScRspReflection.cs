using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TrainCakeCatchOpenBoxScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TrainCakeCatchOpenBoxScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiBUcmFpbkNha2VDYXRjaE9wZW5Cb3hTY1JzcC5wcm90bxoRTlBMRURIRk1G";
		buffer[1] = "RE0ucHJvdG8iZQoaVHJhaW5DYWtlQ2F0Y2hPcGVuQm94U2NSc3ASIQoLQUZF";
		buffer[2] = "SkFDTUxPTEgYBiADKAsyDC5OUExFREhGTUZETRITCgtESExHQ0VHT05JQhgM";
		buffer[3] = "IAEoAxIPCgdyZXRjb2RlGA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv";
		buffer[4] = "YgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { NPLEDHFMFDMReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TrainCakeCatchOpenBoxScRsp), TrainCakeCatchOpenBoxScRsp.Parser, new string[3] { "AFEJACMLOLH", "DHLGCEGONIB", "Retcode" }, null, null, null, null)
		}));
	}
}
