using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeRechargeBenefitRewardCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeRechargeBenefitRewardCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRUYWtlUmVjaGFyZ2VCZW5lZml0UmV3YXJkQ3NSZXEucHJvdG8iLAoeVGFr" + "ZVJlY2hhcmdlQmVuZWZpdFJld2FyZENzUmVxEgoKAmlkGAogASgNQhaqAhNN" + "YXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeRechargeBenefitRewardCsReq), TakeRechargeBenefitRewardCsReq.Parser, new string[1] { "Id" }, null, null, null, null)
		}));
	}
}
