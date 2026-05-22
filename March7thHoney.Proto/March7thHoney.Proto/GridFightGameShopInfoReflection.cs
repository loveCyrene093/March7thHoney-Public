using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightGameShopInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightGameShopInfoReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "ChtHcmlkRmlnaHRHYW1lU2hvcEluZm8ucHJvdG8aEUZKUE9OSkZMT09ILnBy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "b3RvGhxHcmlkRmlnaHRTaG9wR29vZHNJbmZvLnByb3RvIsMBChVHcmlkRmln";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "aHRHYW1lU2hvcEluZm8SEwoLTkRHTUNKSEtOSU4YASABKA0SEwoLRE5PSUZN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "TUxKRE4YAiADKA0SEwoLR0xJRk5NQk1NQkwYAyABKA0SIQoLTERFREdPT0tI";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "RkwYBCABKAsyDC5GSlBPTkpGTE9PSBIWCg5zaG9wX2lzX2xvY2tlZBgIIAEo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "CBIwCg9zaG9wX2dvb2RzX2xpc3QYCiADKAsyFy5HcmlkRmlnaHRTaG9wR29v";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "ZHNJbmZvQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[2]
		{
			FJPONJFLOOHReflection.Descriptor,
			GridFightShopGoodsInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightGameShopInfo), GridFightGameShopInfo.Parser, new string[6] { "NDGMCJHKNIN", "DNOIFMMLJDN", "GLIFNMBMMBL", "LDEDGOOKHFL", "ShopIsLocked", "ShopGoodsList" }, null, null, null, null)
		}));
	}
}
