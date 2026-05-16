using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MatchThreeV2LevelEndScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MatchThreeV2LevelEndScRspReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		buffer[0] = "Ch9NYXRjaFRocmVlVjJMZXZlbEVuZFNjUnNwLnByb3RvGhFCRU9QRE1MS0dM";
		buffer[1] = "UC5wcm90bxoRREFQRE9IT0FEREIucHJvdG8aDkl0ZW1MaXN0LnByb3RvIu4B";
		buffer[2] = "ChlNYXRjaFRocmVlVjJMZXZlbEVuZFNjUnNwEiEKC01PRERJQkhDUFBEGAEg";
		buffer[3] = "ASgLMgwuQkVPUERNTEtHTFASHgoLTEFFSkxMQ0dGRE0YAiABKAsyCS5JdGVt";
		buffer[4] = "TGlzdBITCgtBTUdNQUROQkZJRhgHIAEoDRIPCgdyZXRjb2RlGAggASgNEhAK";
		buffer[5] = "CGxldmVsX2lkGAkgASgNEh4KC0hOQUdPRUVQQkpOGAogAygLMgkuSXRlbUxp";
		buffer[6] = "c3QSIQoLRUJKSEtJS09MSEoYDSABKAsyDC5EQVBET0hPQUREQhITCgtQS0lO";
		buffer[7] = "RlBHRklOQRgOIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			BEOPDMLKGLPReflection.Descriptor,
			DAPDOHOADDBReflection.Descriptor,
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MatchThreeV2LevelEndScRsp), MatchThreeV2LevelEndScRsp.Parser, new string[8] { "MODDIBHCPPD", "LAEJLLCGFDM", "AMGMADNBFIF", "Retcode", "LevelId", "HNAGOEEPBJN", "EBJHKIKOLHJ", "PKINFPGFINA" }, null, null, null, null)
		}));
	}
}
