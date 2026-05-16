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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "ChZHZXRSYWlkSW5mb1NjUnNwLnByb3RvGhFFTkRPTEVKQ0hLUC5wcm90bxoW";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "RmluaXNoZWRSYWlkSW5mby5wcm90byKqAQoQR2V0UmFpZEluZm9TY1JzcBIm";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "Ch5jaGFsbGVuZ2VfdGFrZW5fcmV3YXJkX2lkX2xpc3QYByADKA0SDwoHcmV0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "Y29kZRgJIAEoDRIpChNjaGFsbGVuZ2VfcmFpZF9saXN0GA0gAygLMgwuRU5E";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "T0xFSkNIS1ASMgoXZmluaXNoZWRfcmFpZF9pbmZvX2xpc3QYDiADKAsyES5G";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "aW5pc2hlZFJhaWRJbmZvQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[2]
		{
			ENDOLEJCHKPReflection.Descriptor,
			FinishedRaidInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetRaidInfoScRsp), GetRaidInfoScRsp.Parser, new string[4] { "ChallengeTakenRewardIdList", "Retcode", "ChallengeRaidList", "FinishedRaidInfoList" }, null, null, null, null)
		}));
	}
}
