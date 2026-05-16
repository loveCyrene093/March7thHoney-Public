using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetRaidInfoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetRaidInfoScRspReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChZHZXRSYWlkSW5mb1NjUnNwLnByb3RvGhFFTkRPTEVKQ0hLUC5wcm90bxoW";
		buffer[1] = "RmluaXNoZWRSYWlkSW5mby5wcm90byKqAQoQR2V0UmFpZEluZm9TY1JzcBIm";
		buffer[2] = "Ch5jaGFsbGVuZ2VfdGFrZW5fcmV3YXJkX2lkX2xpc3QYByADKA0SDwoHcmV0";
		buffer[3] = "Y29kZRgJIAEoDRIpChNjaGFsbGVuZ2VfcmFpZF9saXN0GA0gAygLMgwuRU5E";
		buffer[4] = "T0xFSkNIS1ASMgoXZmluaXNoZWRfcmFpZF9pbmZvX2xpc3QYDiADKAsyES5G";
		buffer[5] = "aW5pc2hlZFJhaWRJbmZvQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90";
		buffer[6] = "bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			ENDOLEJCHKPReflection.Descriptor,
			FinishedRaidInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetRaidInfoScRsp), GetRaidInfoScRsp.Parser, new string[4] { "ChallengeTakenRewardIdList", "Retcode", "ChallengeRaidList", "FinishedRaidInfoList" }, null, null, null, null)
		}));
	}
}
