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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 0) = "CgtSZWxpYy5wcm90bxoQUmVsaWNBZmZpeC5wcm90byK3AgoFUmVsaWMSKwoW";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 1) = "cmVmb3JnZV9zdWJfYWZmaXhfbGlzdBgBIAMoCzILLlJlbGljQWZmaXgSFAoM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 2) = "aXNfZGlzY2FyZGVkGAIgASgIEiMKDnN1Yl9hZmZpeF9saXN0GAMgAygLMgsu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 3) = "UmVsaWNBZmZpeBIgCgtFQkVPRUNKTUJLThgEIAMoCzILLlJlbGljQWZmaXgS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 4) = "FwoPZHJlc3NfYXZhdGFyX2lkGAUgASgNEhQKDGlzX3Byb3RlY3RlZBgGIAEo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 5) = "CBINCgVsZXZlbBgHIAEoDRILCgN0aWQYCCABKA0SFQoNbWFpbl9hZmZpeF9p";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 6) = "ZBgJIAEoDRIRCgl1bmlxdWVfaWQYCiABKA0SIgoacmVmb3JnZV9ibG9ja19z";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 7) = "dWJfYWZmaXhfaWQYDCABKA0SCwoDZXhwGA0gASgNQhaqAhNNYXJjaDd0aEhv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 8) = "bmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray9<string>, string>(in buffer, 9))), new FileDescriptor[1] { RelicAffixReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(Relic), Relic.Parser, new string[12]
			{
				"ReforgeSubAffixList", "IsDiscarded", "SubAffixList", "EBEOECJMBKN", "DressAvatarId", "IsProtected", "Level", "Tid", "MainAffixId", "UniqueId",
				"ReforgeBlockSubAffixId", "Exp"
			}, null, null, null, null)
		}));
	}
}
