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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 0) = "ChtDaGFsbGVuZ2VTZXR0bGVOb3RpZnkucHJvdG8aHkNoYWxsZW5nZUhpc3Rv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 1) = "cnlNYXhMZXZlbC5wcm90bxoSQ3VyQ2hhbGxlbmdlLnByb3RvGg5JdGVtTGlz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 2) = "dC5wcm90byKQAgoVQ2hhbGxlbmdlU2V0dGxlTm90aWZ5EhQKDGNoYWxsZW5n";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 3) = "ZV9pZBgBIAEoDRITCgtNSEFQSUhDSlBKTRgCIAEoDRIMCgRzdGFyGAQgASgN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 4) = "EhMKC0VBQ0tOT0FGSUNGGAkgAygNEhkKBnJld2FyZBgKIAEoCzIJLkl0ZW1M";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 5) = "aXN0EiQKDWN1cl9jaGFsbGVuZ2UYCyABKAsyDS5DdXJDaGFsbGVuZ2USDgoG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 6) = "aXNfd2luGAwgASgIEiwKCW1heF9sZXZlbBgNIAEoCzIZLkNoYWxsZW5nZUhp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 7) = "c3RvcnlNYXhMZXZlbBIXCg9jaGFsbGVuZ2Vfc2NvcmUYDiABKA0SEQoJc2Nv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 8) = "cmVfdHdvGA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray9<string>, string>(in buffer, 9))), new FileDescriptor[3]
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
