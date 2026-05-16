using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FriendChallengeLineupReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FriendChallengeLineupReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 0) = "ChtGcmllbmRDaGFsbGVuZ2VMaW5ldXAucHJvdG8aGUNoYWxsZW5nZUxpbmV1";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 1) = "cExpc3QucHJvdG8aFlBsYXllclNpbXBsZUluZm8ucHJvdG8iygEKFUZyaWVu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 2) = "ZENoYWxsZW5nZUxpbmV1cBImCgtwbGF5ZXJfaW5mbxgFIAEoCzIRLlBsYXll";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 3) = "clNpbXBsZUluZm8SEwoLQUJKR05CSk1KSkcYByABKA0SEAoIYnVmZl9vbmUY";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 4) = "CCABKA0SEAoIc2NvcmVfaWQYCSABKA0SEwoLcmVtYXJrX25hbWUYDCABKAkS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 5) = "KQoLbGluZXVwX2xpc3QYDiADKAsyFC5DaGFsbGVuZ2VMaW5ldXBMaXN0EhAK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 6) = "CGJ1ZmZfdHdvGA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 7) = "bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray8<string>, string>(in buffer, 8))), new FileDescriptor[2]
		{
			ChallengeLineupListReflection.Descriptor,
			PlayerSimpleInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FriendChallengeLineup), FriendChallengeLineup.Parser, new string[7] { "PlayerInfo", "ABJGNBJMJJG", "BuffOne", "ScoreId", "RemarkName", "LineupList", "BuffTwo" }, null, null, null, null)
		}));
	}
}
