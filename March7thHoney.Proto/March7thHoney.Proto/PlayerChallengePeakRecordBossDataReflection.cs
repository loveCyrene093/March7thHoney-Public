using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlayerChallengePeakRecordBossDataReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlayerChallengePeakRecordBossDataReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 0) = "CidQbGF5ZXJDaGFsbGVuZ2VQZWFrUmVjb3JkQm9zc0RhdGEucHJvdG8aGUNo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 1) = "YWxsZW5nZUxpbmV1cExpc3QucHJvdG8i2QEKIVBsYXllckNoYWxsZW5nZVBl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 2) = "YWtSZWNvcmRCb3NzRGF0YRIkCgZsaW5ldXAYASABKAsyFC5DaGFsbGVuZ2VM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 3) = "aW5ldXBMaXN0EhMKC09CUERFTkxNTklJGAMgAygNEhgKEGJlc3RfY3ljbGVf";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 4) = "Y291bnQYBiABKA0SEwoLRVBDTUFERk9BQ0EYByABKAgSDwoHYnVmZl9pZBgI";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 5) = "IAEoDRITCgtIRUlMS0JKQ0FHQhgJIAEoDRITCgtBRkZJS0FBTUVKRRgKIAEo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 6) = "CBIPCgdwZWFrX2lkGAsgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 7) = "cm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray8<string>, string>(in buffer, 8))), new FileDescriptor[1] { ChallengeLineupListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlayerChallengePeakRecordBossData), PlayerChallengePeakRecordBossData.Parser, new string[8] { "Lineup", "OBPDENLMNII", "BestCycleCount", "EPCMADFOACA", "BuffId", "HEILKBJCAGB", "AFFIKAAMEJE", "PeakId" }, null, null, null, null)
		}));
	}
}
