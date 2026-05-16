using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeTrialActivityRewardCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeTrialActivityRewardCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJUYWtlVHJpYWxBY3Rpdml0eVJld2FyZENzUmVxLnByb3RvIjAKHFRha2VU" + "cmlhbEFjdGl2aXR5UmV3YXJkQ3NSZXESEAoIc3RhZ2VfaWQYCyABKA1CFqoC" + "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeTrialActivityRewardCsReq), TakeTrialActivityRewardCsReq.Parser, new string[1] { "StageId" }, null, null, null, null)
		}));
	}
}
