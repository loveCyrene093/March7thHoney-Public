using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RelicSmartWearAddPlanScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RelicSmartWearAddPlanScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBSZWxpY1NtYXJ0V2VhckFkZFBsYW5TY1JzcC5wcm90bxoYUmVsaWNTbWFy" + "dFdlYXJQbGFuLnByb3RvIlYKGlJlbGljU21hcnRXZWFyQWRkUGxhblNjUnNw" + "Eg8KB3JldGNvZGUYCyABKA0SJwoKcmVsaWNfcGxhbhgMIAEoCzITLlJlbGlj" + "U21hcnRXZWFyUGxhbkIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { RelicSmartWearPlanReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RelicSmartWearAddPlanScRsp), RelicSmartWearAddPlanScRsp.Parser, new string[2] { "Retcode", "RelicPlan" }, null, null, null, null)
		}));
	}
}
