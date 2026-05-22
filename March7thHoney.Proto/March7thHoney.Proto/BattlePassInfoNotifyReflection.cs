using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BattlePassInfoNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BattlePassInfoNotifyReflection()
	{
		InlineArray9<string> buffer = default(InlineArray9<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 0) = "ChpCYXR0bGVQYXNzSW5mb05vdGlmeS5wcm90bxoQQnBUaWVyVHlwZS5wcm90";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 1) = "byKlAgoUQmF0dGxlUGFzc0luZm9Ob3RpZnkSEwoLSEVCSUxKSUlJQ0cYASAB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 2) = "KAQSEwoLSUhNTk1OQktKUEcYAiABKAQSEwoLRURHRUNIQ0xESEcYAyABKA0S";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 3) = "EwoLS0JDUE5BTURCSkUYBCABKAQSCwoDZXhwGAUgASgNEhMKC09LTk1HSEdB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 4) = "RUlHGAcgASgEEhMKC0NES0NHQUtBQkFMGAggASgEEh8KCkJwVGllclR5cGUY";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 5) = "CSABKA4yCy5CcFRpZXJUeXBlEg0KBWxldmVsGAogASgNEhMKC0dDTFBMQU9J";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 6) = "SkVPGAsgASgNEhMKC0FFR0xPQUFQSEVCGAwgASgEEhMKC0dFTklOT0dLTEFQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 7) = "GA4gASgEEhMKC0tQT0dBSkJMRE5DGA8gASgEQhaqAhNNYXJjaDd0aEhvbmV5";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 8) = "LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray9<string>, string>(in buffer, 9))), new FileDescriptor[1] { BpTierTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BattlePassInfoNotify), BattlePassInfoNotify.Parser, new string[13]
			{
				"HEBILJIIICG", "IHMNMNBKJPG", "EDGECHCLDHG", "KBCPNAMDBJE", "Exp", "OKNMGHGAEIG", "CDKCGAKABAL", "BpTierType", "Level", "GCLPLAOIJEO",
				"AEGLOAAPHEB", "GENINOGKLAP", "KPOGAJBLDNC"
			}, null, null, null, null)
		}));
	}
}
