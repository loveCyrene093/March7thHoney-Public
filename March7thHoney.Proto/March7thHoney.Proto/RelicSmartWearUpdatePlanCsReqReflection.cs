using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RelicSmartWearUpdatePlanCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RelicSmartWearUpdatePlanCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNSZWxpY1NtYXJ0V2VhclVwZGF0ZVBsYW5Dc1JlcS5wcm90bxoYUmVsaWNT" + "bWFydFdlYXJQbGFuLnByb3RvIkgKHVJlbGljU21hcnRXZWFyVXBkYXRlUGxh" + "bkNzUmVxEicKCnJlbGljX3BsYW4YCCABKAsyEy5SZWxpY1NtYXJ0V2VhclBs" + "YW5CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { RelicSmartWearPlanReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RelicSmartWearUpdatePlanCsReq), RelicSmartWearUpdatePlanCsReq.Parser, new string[1] { "RelicPlan" }, null, null, null, null)
		}));
	}
}
