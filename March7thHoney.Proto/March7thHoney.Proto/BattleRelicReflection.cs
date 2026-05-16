using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BattleRelicReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BattleRelicReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChFCYXR0bGVSZWxpYy5wcm90bxoQUmVsaWNBZmZpeC5wcm90byKlAQoLQmF0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "dGxlUmVsaWMSCgoCaWQYASABKA0SDQoFbGV2ZWwYAiABKA0SFQoNbWFpbl9h";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "ZmZpeF9pZBgDIAEoDRIjCg5zdWJfYWZmaXhfbGlzdBgEIAMoCzILLlJlbGlj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "QWZmaXgSEQoJdW5pcXVlX2lkGAUgASgNEg4KBnNldF9pZBgGIAEoDRIMCgR0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "eXBlGAcgASgNEg4KBnJhcml0eRgIIAEoDUIWqgITTWFyY2g3dGhIb25leS5Q";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "cm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[1] { RelicAffixReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BattleRelic), BattleRelic.Parser, new string[8] { "Id", "Level", "MainAffixId", "SubAffixList", "UniqueId", "SetId", "Type", "Rarity" }, null, null, null, null)
		}));
	}
}
