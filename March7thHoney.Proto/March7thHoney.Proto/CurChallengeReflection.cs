using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CurChallengeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CurChallengeReflection()
	{
		InlineArray10<string> buffer = default(InlineArray10<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 0) = "ChJDdXJDaGFsbGVuZ2UucHJvdG8aGkNoYWxsZW5nZUN1ckJ1ZmZJbmZvLnBy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 1) = "b3RvGhVDaGFsbGVuZ2VTdGF0dXMucHJvdG8aFUV4dHJhTGluZXVwVHlwZS5w";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 2) = "cm90bxoRS2lsbE1vbnN0ZXIucHJvdG8imgIKDEN1ckNoYWxsZW5nZRITCgty";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 3) = "b3VuZF9jb3VudBgBIAEoDRIpCgpzdGFnZV9pbmZvGAIgASgLMhUuQ2hhbGxl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 4) = "bmdlQ3VyQnVmZkluZm8SKwoRZXh0cmFfbGluZXVwX3R5cGUYBCABKA4yEC5F";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 5) = "eHRyYUxpbmV1cFR5cGUSEAoIc2NvcmVfaWQYBSABKA0SJwoRa2lsbF9tb25z";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 6) = "dGVyX2xpc3QYByADKAsyDC5LaWxsTW9uc3RlchIgCgZzdGF0dXMYCCABKA4y";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 7) = "EC5DaGFsbGVuZ2VTdGF0dXMSFAoMY2hhbGxlbmdlX2lkGAkgASgNEhcKD2Rl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 8) = "YWRfYXZhdGFyX251bRgKIAEoDRIRCglzY29yZV90d28YDSABKA1CFqoCE01h";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 9) = "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray10<string>, string>(in buffer, 10))), new FileDescriptor[4]
		{
			ChallengeCurBuffInfoReflection.Descriptor,
			ChallengeStatusReflection.Descriptor,
			ExtraLineupTypeReflection.Descriptor,
			KillMonsterReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CurChallenge), CurChallenge.Parser, new string[9] { "RoundCount", "StageInfo", "ExtraLineupType", "ScoreId", "KillMonsterList", "Status", "ChallengeId", "DeadAvatarNum", "ScoreTwo" }, null, null, null, null)
		}));
	}
}
