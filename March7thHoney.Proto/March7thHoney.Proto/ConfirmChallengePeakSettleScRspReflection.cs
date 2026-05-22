using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ConfirmChallengePeakSettleScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ConfirmChallengePeakSettleScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVDb25maXJtQ2hhbGxlbmdlUGVha1NldHRsZVNjUnNwLnByb3RvIlgKH0Nv" + "bmZpcm1DaGFsbGVuZ2VQZWFrU2V0dGxlU2NSc3ASDwoHcGVha19pZBgHIAEo" + "DRIPCgdyZXRjb2RlGAggASgNEhMKC0FCSE9MTkpOUEpNGAwgASgIQhaqAhNN" + "YXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ConfirmChallengePeakSettleScRsp), ConfirmChallengePeakSettleScRsp.Parser, new string[3] { "PeakId", "Retcode", "ABHOLNJNPJM" }, null, null, null, null)
		}));
	}
}
