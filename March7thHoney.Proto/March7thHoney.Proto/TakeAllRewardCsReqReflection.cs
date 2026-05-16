using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeAllRewardCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeAllRewardCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhUYWtlQWxsUmV3YXJkQ3NSZXEucHJvdG8aFE9wdGlvbmFsUmV3YXJkLnBy" + "b3RvIjoKElRha2VBbGxSZXdhcmRDc1JlcRIkCgtHR0JLT0ZLRUhORBgJIAMo" + "CzIPLk9wdGlvbmFsUmV3YXJkQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw" + "cm90bzM="), new FileDescriptor[1] { OptionalRewardReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeAllRewardCsReq), TakeAllRewardCsReq.Parser, new string[1] { "GGBKOFKEHND" }, null, null, null, null)
		}));
	}
}
