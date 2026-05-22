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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 0) = "Ch9NYXRjaFRocmVlVjJMZXZlbEVuZFNjUnNwLnByb3RvGhFCRU9QRE1MS0dM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 1) = "UC5wcm90bxoRREFQRE9IT0FEREIucHJvdG8aDkl0ZW1MaXN0LnByb3RvIu4B";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 2) = "ChlNYXRjaFRocmVlVjJMZXZlbEVuZFNjUnNwEiEKC01PRERJQkhDUFBEGAEg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 3) = "ASgLMgwuQkVPUERNTEtHTFASHgoLTEFFSkxMQ0dGRE0YAiABKAsyCS5JdGVt";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 4) = "TGlzdBITCgtBTUdNQUROQkZJRhgHIAEoDRIPCgdyZXRjb2RlGAggASgNEhAK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 5) = "CGxldmVsX2lkGAkgASgNEh4KC0hOQUdPRUVQQkpOGAogAygLMgkuSXRlbUxp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 6) = "c3QSIQoLRUJKSEtJS09MSEoYDSABKAsyDC5EQVBET0hPQUREQhITCgtQS0lO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 7) = "RlBHRklOQRgOIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray8<string>, string>(in buffer, 8))), new FileDescriptor[3]
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
