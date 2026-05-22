using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlayerChallengePeakRecordMobDataReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlayerChallengePeakRecordMobDataReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "CiZQbGF5ZXJDaGFsbGVuZ2VQZWFrUmVjb3JkTW9iRGF0YS5wcm90bxoZQ2hh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "bGxlbmdlTGluZXVwTGlzdC5wcm90byKDAQogUGxheWVyQ2hhbGxlbmdlUGVh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "a1JlY29yZE1vYkRhdGESEwoLY3ljbGVzX3VzZWQYASABKA0SDwoHcGVha19p";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "ZBgDIAEoDRIkCgZsaW5ldXAYBCABKAsyFC5DaGFsbGVuZ2VMaW5ldXBMaXN0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "EhMKC09CUERFTkxNTklJGAggAygNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "YgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[1] { ChallengeLineupListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlayerChallengePeakRecordMobData), PlayerChallengePeakRecordMobData.Parser, new string[4] { "CyclesUsed", "PeakId", "Lineup", "OBPDENLMNII" }, null, null, null, null)
		}));
	}
}
