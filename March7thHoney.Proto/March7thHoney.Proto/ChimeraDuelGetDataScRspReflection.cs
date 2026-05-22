using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChimeraDuelGetDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChimeraDuelGetDataScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "Ch1DaGltZXJhRHVlbEdldERhdGFTY1JzcC5wcm90bxoRRERKT0VJQk9FTEgu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "cHJvdG8aEU5DQkxPQlBQSUJELnByb3RvInAKF0NoaW1lcmFEdWVsR2V0RGF0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "YVNjUnNwEiEKC0JBS0tJQ0tIRkRHGAIgASgLMgwuTkNCTE9CUFBJQkQSDwoH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "cmV0Y29kZRgDIAEoDRIhCgtPSUFQSEJCRFBITBgNIAEoCzIMLkRESk9FSUJP";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "RUxIQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			DDJOEIBOELHReflection.Descriptor,
			NCBLOBPPIBDReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChimeraDuelGetDataScRsp), ChimeraDuelGetDataScRsp.Parser, new string[3] { "BAKKICKHFDG", "Retcode", "OIAPHBBDPHL" }, null, null, null, null)
		}));
	}
}
