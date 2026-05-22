using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BattleBuffReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BattleBuffReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChBCYXR0bGVCdWZmLnByb3RvItgBCgpCYXR0bGVCdWZmEgoKAmlkGAEgASgN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "Eg0KBWxldmVsGAIgASgNEhMKC293bmVyX2luZGV4GAMgASgNEhEKCXdhdmVf";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "ZmxhZxgEIAEoDRIZChF0YXJnZXRfaW5kZXhfbGlzdBgFIAMoDRI2Cg5keW5h";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "bWljX3ZhbHVlcxgGIAMoCzIeLkJhdHRsZUJ1ZmYuRHluYW1pY1ZhbHVlc0Vu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "dHJ5GjQKEkR5bmFtaWNWYWx1ZXNFbnRyeRILCgNrZXkYASABKAkSDQoFdmFs";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "dWUYAiABKAI6AjgBQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BattleBuff), BattleBuff.Parser, new string[6] { "Id", "Level", "OwnerIndex", "WaveFlag", "TargetIndexList", "DynamicValues" }, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
