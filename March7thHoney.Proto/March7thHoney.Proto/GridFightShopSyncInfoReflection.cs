using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightShopSyncInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightShopSyncInfoReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "ChtHcmlkRmlnaHRTaG9wU3luY0luZm8ucHJvdG8aEUZKUE9OSkZMT09ILnBy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "b3RvGhxHcmlkRmlnaHRTaG9wR29vZHNJbmZvLnByb3RvIq4BChVHcmlkRmln";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "aHRTaG9wU3luY0luZm8SEwoLR0xJRk5NQk1NQkwYAiABKA0SMAoPc2hvcF9n";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "b29kc19saXN0GAUgAygLMhcuR3JpZEZpZ2h0U2hvcEdvb2RzSW5mbxIhCgtM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "REVER09PS0hGTBgKIAEoCzIMLkZKUE9OSkZMT09IEhMKC05ER01DSkhLTklO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "GAsgASgNEhYKDnNob3BfaXNfbG9ja2VkGA8gASgIQhaqAhNNYXJjaDd0aEhv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "bmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[2]
		{
			FJPONJFLOOHReflection.Descriptor,
			GridFightShopGoodsInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightShopSyncInfo), GridFightShopSyncInfo.Parser, new string[5] { "GLIFNMBMMBL", "ShopGoodsList", "LDEDGOOKHFL", "NDGMCJHKNIN", "ShopIsLocked" }, null, null, null, null)
		}));
	}
}
