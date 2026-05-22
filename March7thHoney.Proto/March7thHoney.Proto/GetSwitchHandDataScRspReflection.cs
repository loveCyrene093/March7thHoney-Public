using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetSwitchHandDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetSwitchHandDataScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChxHZXRTd2l0Y2hIYW5kRGF0YVNjUnNwLnByb3RvGhFHT0RIREVJUERKTC5w";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "cm90byJ2ChZHZXRTd2l0Y2hIYW5kRGF0YVNjUnNwEhMKC0ZQQkpJRkxHSU1L";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "GAQgASgNEiEKC0xGTklQRUNLTkRIGAggAygLMgwuR09ESERFSVBESkwSEwoL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "QUlOTElBSUdPSkYYDSABKA0SDwoHcmV0Y29kZRgPIAEoDUIWqgITTWFyY2g3";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { GODHDEIPDJLReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetSwitchHandDataScRsp), GetSwitchHandDataScRsp.Parser, new string[4] { "FPBJIFLGIMK", "LFNIPECKNDH", "AINLIAIGOJF", "Retcode" }, null, null, null, null)
		}));
	}
}
