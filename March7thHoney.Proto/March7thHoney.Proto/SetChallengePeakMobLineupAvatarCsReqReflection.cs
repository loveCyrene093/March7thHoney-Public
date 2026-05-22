using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetChallengePeakMobLineupAvatarCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetChallengePeakMobLineupAvatarCsReqReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "CipTZXRDaGFsbGVuZ2VQZWFrTW9iTGluZXVwQXZhdGFyQ3NSZXEucHJvdG8a";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "GUNoYWxsZW5nZVBlYWtMaW5ldXAucHJvdG8ifQokU2V0Q2hhbGxlbmdlUGVh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "a01vYkxpbmV1cEF2YXRhckNzUmVxEikKC2xpbmV1cF9saXN0GAIgAygLMhQu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "Q2hhbGxlbmdlUGVha0xpbmV1cBITCgtITkdQUEZQT09DRBgFIAMoDRIVCg1w";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "ZWFrX2dyb3VwX2lkGAggASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "cm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[1] { ChallengePeakLineupReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetChallengePeakMobLineupAvatarCsReq), SetChallengePeakMobLineupAvatarCsReq.Parser, new string[3] { "LineupList", "HNGPPFPOOCD", "PeakGroupId" }, null, null, null, null)
		}));
	}
}
