using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeLoginActivityRewardCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeLoginActivityRewardCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJUYWtlTG9naW5BY3Rpdml0eVJld2FyZENzUmVxLnByb3RvIj0KHFRha2VM" + "b2dpbkFjdGl2aXR5UmV3YXJkQ3NSZXESEQoJdGFrZV9kYXlzGAMgASgNEgoK" + "AmlkGA4gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeLoginActivityRewardCsReq), TakeLoginActivityRewardCsReq.Parser, new string[2] { "TakeDays", "Id" }, null, null, null, null)
		}));
	}
}
