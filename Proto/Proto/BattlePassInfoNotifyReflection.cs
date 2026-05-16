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
		buffer[0] = "ChpCYXR0bGVQYXNzSW5mb05vdGlmeS5wcm90bxoQQnBUaWVyVHlwZS5wcm90";
		buffer[1] = "byKlAgoUQmF0dGxlUGFzc0luZm9Ob3RpZnkSEwoLSEVCSUxKSUlJQ0cYASAB";
		buffer[2] = "KAQSEwoLSUhNTk1OQktKUEcYAiABKAQSEwoLRURHRUNIQ0xESEcYAyABKA0S";
		buffer[3] = "EwoLS0JDUE5BTURCSkUYBCABKAQSCwoDZXhwGAUgASgNEhMKC09LTk1HSEdB";
		buffer[4] = "RUlHGAcgASgEEhMKC0NES0NHQUtBQkFMGAggASgEEh8KCkJwVGllclR5cGUY";
		buffer[5] = "CSABKA4yCy5CcFRpZXJUeXBlEg0KBWxldmVsGAogASgNEhMKC0dDTFBMQU9J";
		buffer[6] = "SkVPGAsgASgNEhMKC0FFR0xPQUFQSEVCGAwgASgEEhMKC0dFTklOT0dLTEFQ";
		buffer[7] = "GA4gASgEEhMKC0tQT0dBSkJMRE5DGA8gASgEQhaqAhNNYXJjaDd0aEhvbmV5";
		buffer[8] = "LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { BpTierTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BattlePassInfoNotify), BattlePassInfoNotify.Parser, new string[13]
			{
				"HEBILJIIICG", "IHMNMNBKJPG", "EDGECHCLDHG", "KBCPNAMDBJE", "Exp", "OKNMGHGAEIG", "CDKCGAKABAL", "BpTierType", "Level", "GCLPLAOIJEO",
				"AEGLOAAPHEB", "GENINOGKLAP", "KPOGAJBLDNC"
			}, null, null, null, null)
		}));
	}
}
