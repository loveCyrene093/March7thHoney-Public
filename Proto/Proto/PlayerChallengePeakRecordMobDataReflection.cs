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
		buffer[0] = "CiZQbGF5ZXJDaGFsbGVuZ2VQZWFrUmVjb3JkTW9iRGF0YS5wcm90bxoZQ2hh";
		buffer[1] = "bGxlbmdlTGluZXVwTGlzdC5wcm90byKDAQogUGxheWVyQ2hhbGxlbmdlUGVh";
		buffer[2] = "a1JlY29yZE1vYkRhdGESEwoLY3ljbGVzX3VzZWQYASABKA0SDwoHcGVha19p";
		buffer[3] = "ZBgDIAEoDRIkCgZsaW5ldXAYBCABKAsyFC5DaGFsbGVuZ2VMaW5ldXBMaXN0";
		buffer[4] = "EhMKC09CUERFTkxNTklJGAggAygNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv";
		buffer[5] = "YgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ChallengeLineupListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlayerChallengePeakRecordMobData), PlayerChallengePeakRecordMobData.Parser, new string[4] { "CyclesUsed", "PeakId", "Lineup", "OBPDENLMNII" }, null, null, null, null)
		}));
	}
}
