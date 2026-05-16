using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RelicSmartWearGetPlanScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RelicSmartWearGetPlanScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiBSZWxpY1NtYXJ0V2VhckdldFBsYW5TY1JzcC5wcm90bxoYUmVsaWNTbWFy";
		buffer[1] = "dFdlYXJQbGFuLnByb3RvIm4KGlJlbGljU21hcnRXZWFyR2V0UGxhblNjUnNw";
		buffer[2] = "EhEKCWF2YXRhcl9pZBgDIAEoDRIPCgdyZXRjb2RlGAQgASgNEiwKD3JlbGlj";
		buffer[3] = "X3BsYW5fbGlzdBgLIAMoCzITLlJlbGljU21hcnRXZWFyUGxhbkIWqgITTWFy";
		buffer[4] = "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { RelicSmartWearPlanReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RelicSmartWearGetPlanScRsp), RelicSmartWearGetPlanScRsp.Parser, new string[3] { "AvatarId", "Retcode", "RelicPlanList" }, null, null, null, null)
		}));
	}
}
