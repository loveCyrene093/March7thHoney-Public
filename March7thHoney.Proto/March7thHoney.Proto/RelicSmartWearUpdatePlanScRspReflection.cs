using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RelicSmartWearUpdatePlanScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RelicSmartWearUpdatePlanScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CiNSZWxpY1NtYXJ0V2VhclVwZGF0ZVBsYW5TY1JzcC5wcm90bxoYUmVsaWNT";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "bWFydFdlYXJQbGFuLnByb3RvIlkKHVJlbGljU21hcnRXZWFyVXBkYXRlUGxh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "blNjUnNwEicKCnJlbGljX3BsYW4YBiABKAsyEy5SZWxpY1NtYXJ0V2VhclBs";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "YW4SDwoHcmV0Y29kZRgLIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "cHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { RelicSmartWearPlanReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RelicSmartWearUpdatePlanScRsp), RelicSmartWearUpdatePlanScRsp.Parser, new string[2] { "RelicPlan", "Retcode" }, null, null, null, null)
		}));
	}
}
