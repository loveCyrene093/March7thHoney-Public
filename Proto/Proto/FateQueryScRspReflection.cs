using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FateQueryScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FateQueryScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChRGYXRlUXVlcnlTY1JzcC5wcm90bxoRS0RKSURKQkJISEUucHJvdG8aEU1G";
		buffer[1] = "TUVNREpLREFGLnByb3RvImoKDkZhdGVRdWVyeVNjUnNwEg8KB3JldGNvZGUY";
		buffer[2] = "BiABKA0SJAoOcm9ndWVfZ2V0X2luZm8YCCABKAsyDC5NRk1FTURKS0RBRhIh";
		buffer[3] = "CgtNT0RESUJIQ1BQRBgLIAEoCzIMLktESklESkJCSEhFQhaqAhNNYXJjaDd0";
		buffer[4] = "aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			KDJIDJBBHHEReflection.Descriptor,
			MFMEMDJKDAFReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FateQueryScRsp), FateQueryScRsp.Parser, new string[3] { "Retcode", "RogueGetInfo", "MODDIBHCPPD" }, null, null, null, null)
		}));
	}
}
