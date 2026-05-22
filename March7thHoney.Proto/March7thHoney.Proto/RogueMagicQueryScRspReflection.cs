using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueMagicQueryScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueMagicQueryScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChpSb2d1ZU1hZ2ljUXVlcnlTY1JzcC5wcm90bxoRQUhOR0lPRkRKTkwucHJv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "dG8aEUFIT0xPSENMTEtELnByb3RvInAKFFJvZ3VlTWFnaWNRdWVyeVNjUnNw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "Eg8KB3JldGNvZGUYBCABKA0SIQoLSEhETEVBREJKR04YCSABKAsyDC5BSE9M";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "T0hDTExLRBIkCg5yb2d1ZV9nZXRfaW5mbxgPIAEoCzIMLkFITkdJT0ZESk5M";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			AHNGIOFDJNLReflection.Descriptor,
			AHOLOHCLLKDReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueMagicQueryScRsp), RogueMagicQueryScRsp.Parser, new string[3] { "Retcode", "HHDLEADBJGN", "RogueGetInfo" }, null, null, null, null)
		}));
	}
}
