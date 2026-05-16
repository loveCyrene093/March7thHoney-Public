using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChallengeSettleNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChallengeSettleNotifyReflection()
	{
		InlineArray9<string> buffer = default(InlineArray9<string>);
		buffer[0] = "ChtDaGFsbGVuZ2VTZXR0bGVOb3RpZnkucHJvdG8aHkNoYWxsZW5nZUhpc3Rv";
		buffer[1] = "cnlNYXhMZXZlbC5wcm90bxoSQ3VyQ2hhbGxlbmdlLnByb3RvGg5JdGVtTGlz";
		buffer[2] = "dC5wcm90byKQAgoVQ2hhbGxlbmdlU2V0dGxlTm90aWZ5EhQKDGNoYWxsZW5n";
		buffer[3] = "ZV9pZBgBIAEoDRITCgtNSEFQSUhDSlBKTRgCIAEoDRIMCgRzdGFyGAQgASgN";
		buffer[4] = "EhMKC0VBQ0tOT0FGSUNGGAkgAygNEhkKBnJld2FyZBgKIAEoCzIJLkl0ZW1M";
		buffer[5] = "aXN0EiQKDWN1cl9jaGFsbGVuZ2UYCyABKAsyDS5DdXJDaGFsbGVuZ2USDgoG";
		buffer[6] = "aXNfd2luGAwgASgIEiwKCW1heF9sZXZlbBgNIAEoCzIZLkNoYWxsZW5nZUhp";
		buffer[7] = "c3RvcnlNYXhMZXZlbBIXCg9jaGFsbGVuZ2Vfc2NvcmUYDiABKA0SEQoJc2Nv";
		buffer[8] = "cmVfdHdvGA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			ChallengeHistoryMaxLevelReflection.Descriptor,
			CurChallengeReflection.Descriptor,
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChallengeSettleNotify), ChallengeSettleNotify.Parser, new string[10] { "ChallengeId", "MHAPIHCJPJM", "Star", "EACKNOAFICF", "Reward", "CurChallenge", "IsWin", "MaxLevel", "ChallengeScore", "ScoreTwo" }, null, null, null, null)
		}));
	}
}
