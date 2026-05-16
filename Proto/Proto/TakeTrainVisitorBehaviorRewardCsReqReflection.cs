using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeTrainVisitorBehaviorRewardCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeTrainVisitorBehaviorRewardCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CilUYWtlVHJhaW5WaXNpdG9yQmVoYXZpb3JSZXdhcmRDc1JlcS5wcm90byI5" + "CiNUYWtlVHJhaW5WaXNpdG9yQmVoYXZpb3JSZXdhcmRDc1JlcRISCgp2aXNp" + "dG9yX2lkGAcgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeTrainVisitorBehaviorRewardCsReq), TakeTrainVisitorBehaviorRewardCsReq.Parser, new string[1] { "VisitorId" }, null, null, null, null)
		}));
	}
}
