using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TrainPartyBuildStartStepScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TrainPartyBuildStartStepScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNUcmFpblBhcnR5QnVpbGRTdGFydFN0ZXBTY1JzcC5wcm90byJCCh1UcmFp" + "blBhcnR5QnVpbGRTdGFydFN0ZXBTY1JzcBIQCghjdXJfZnVuZBgIIAEoDRIP" + "CgdyZXRjb2RlGA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TrainPartyBuildStartStepScRsp), TrainPartyBuildStartStepScRsp.Parser, new string[2] { "CurFund", "Retcode" }, null, null, null, null)
		}));
	}
}
