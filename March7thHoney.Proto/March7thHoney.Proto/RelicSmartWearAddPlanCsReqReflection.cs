using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RelicSmartWearAddPlanCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RelicSmartWearAddPlanCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBSZWxpY1NtYXJ0V2VhckFkZFBsYW5Dc1JlcS5wcm90bxoYUmVsaWNTbWFy" + "dFdlYXJQbGFuLnByb3RvIkUKGlJlbGljU21hcnRXZWFyQWRkUGxhbkNzUmVx" + "EicKCnJlbGljX3BsYW4YBiABKAsyEy5SZWxpY1NtYXJ0V2VhclBsYW5CFqoC" + "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { RelicSmartWearPlanReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RelicSmartWearAddPlanCsReq), RelicSmartWearAddPlanCsReq.Parser, new string[1] { "RelicPlan" }, null, null, null, null)
		}));
	}
}
