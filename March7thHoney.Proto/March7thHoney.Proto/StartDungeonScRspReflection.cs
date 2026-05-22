using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class StartDungeonScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static StartDungeonScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChdTdGFydER1bmdlb25TY1JzcC5wcm90bxoRR0tERUtKS09JSk4ucHJvdG8a";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "EVBEUEFMUERBTERHLnByb3RvIqIBChFTdGFydER1bmdlb25TY1JzcBITCgt0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "YXJnZXRfc2lkZRgDIAEoDRIPCgdyZXRjb2RlGAYgASgNEiEKC0xCQ0lLUEVG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "QUlQGAggAygLMgwuUERQQUxQREFMREcSIQoLT0lDRUpJTUVPTkcYCiADKAsy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "DC5HS0RFS0pLT0lKThIhCgtDUE9NTkdKREJDTBgLIAMoCzIMLkdLREVLSktP";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "SUpOQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[2]
		{
			GKDEKJKOIJNReflection.Descriptor,
			PDPALPDALDGReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(StartDungeonScRsp), StartDungeonScRsp.Parser, new string[5] { "TargetSide", "Retcode", "LBCIKPEFAIP", "OICEJIMEONG", "CPOMNGJDBCL" }, null, null, null, null)
		}));
	}
}
