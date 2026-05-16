using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RelicReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RelicReflection()
	{
		InlineArray9<string> buffer = default(InlineArray9<string>);
		buffer[0] = "CgtSZWxpYy5wcm90bxoQUmVsaWNBZmZpeC5wcm90byK3AgoFUmVsaWMSKwoW";
		buffer[1] = "cmVmb3JnZV9zdWJfYWZmaXhfbGlzdBgBIAMoCzILLlJlbGljQWZmaXgSFAoM";
		buffer[2] = "aXNfZGlzY2FyZGVkGAIgASgIEiMKDnN1Yl9hZmZpeF9saXN0GAMgAygLMgsu";
		buffer[3] = "UmVsaWNBZmZpeBIgCgtFQkVPRUNKTUJLThgEIAMoCzILLlJlbGljQWZmaXgS";
		buffer[4] = "FwoPZHJlc3NfYXZhdGFyX2lkGAUgASgNEhQKDGlzX3Byb3RlY3RlZBgGIAEo";
		buffer[5] = "CBINCgVsZXZlbBgHIAEoDRILCgN0aWQYCCABKA0SFQoNbWFpbl9hZmZpeF9p";
		buffer[6] = "ZBgJIAEoDRIRCgl1bmlxdWVfaWQYCiABKA0SIgoacmVmb3JnZV9ibG9ja19z";
		buffer[7] = "dWJfYWZmaXhfaWQYDCABKA0SCwoDZXhwGA0gASgNQhaqAhNNYXJjaDd0aEhv";
		buffer[8] = "bmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { RelicAffixReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(Relic), Relic.Parser, new string[12]
			{
				"ReforgeSubAffixList", "IsDiscarded", "SubAffixList", "EBEOECJMBKN", "DressAvatarId", "IsProtected", "Level", "Tid", "MainAffixId", "UniqueId",
				"ReforgeBlockSubAffixId", "Exp"
			}, null, null, null, null)
		}));
	}
}
