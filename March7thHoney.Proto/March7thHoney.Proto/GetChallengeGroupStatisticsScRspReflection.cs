using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetChallengeGroupStatisticsScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetChallengeGroupStatisticsScRspReflection()
	{
		InlineArray10<string> buffer = default(InlineArray10<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 0) = "CiZHZXRDaGFsbGVuZ2VHcm91cFN0YXRpc3RpY3NTY1JzcC5wcm90bxodQ2hh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 1) = "bGxlbmdlQm9zc1N0YXRpc3RpY3MucHJvdG8aGUNoYWxsZW5nZVN0YXRpc3Rp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 2) = "Y3MucHJvdG8aHkNoYWxsZW5nZVN0b3J5U3RhdGlzdGljcy5wcm90byLxAQog";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 3) = "R2V0Q2hhbGxlbmdlR3JvdXBTdGF0aXN0aWNzU2NSc3ASEAoIZ3JvdXBfaWQY";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 4) = "CCABKA0SDwoHcmV0Y29kZRgMIAEoDRI0Cg9jaGFsbGVuZ2Vfc3RvcnkYASAB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 5) = "KAsyGS5DaGFsbGVuZ2VTdG9yeVN0YXRpc3RpY3NIABIxChFjaGFsbGVuZ2Vf";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 6) = "ZGVmYXVsdBgGIAEoCzIULkNoYWxsZW5nZVN0YXRpc3RpY3NIABIyCg5jaGFs";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 7) = "bGVuZ2VfYm9zcxgHIAEoCzIYLkNoYWxsZW5nZUJvc3NTdGF0aXN0aWNzSABC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 8) = "DQoLSElBQ05ITkxDR0xCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 9) = "Mw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray10<string>, string>(in buffer, 10))), new FileDescriptor[3]
		{
			ChallengeBossStatisticsReflection.Descriptor,
			ChallengeStatisticsReflection.Descriptor,
			ChallengeStoryStatisticsReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetChallengeGroupStatisticsScRsp), GetChallengeGroupStatisticsScRsp.Parser, new string[5] { "GroupId", "Retcode", "ChallengeStory", "ChallengeDefault", "ChallengeBoss" }, new string[1] { "HIACNHNLCGL" }, null, null, null)
		}));
	}
}
