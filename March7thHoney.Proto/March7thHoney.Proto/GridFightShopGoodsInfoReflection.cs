using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightShopGoodsInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightShopGoodsInfoReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 0) = "ChxHcmlkRmlnaHRTaG9wR29vZHNJbmZvLnByb3RvGhxHcmlkRmlnaHRSb2xl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 1) = "R29vZHNJbmZvLnByb3RvGh9HcmlkRmlnaHRTcGVjaWFsR29vZHNJbmZvLnBy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 2) = "b3RvIsYBChZHcmlkRmlnaHRTaG9wR29vZHNJbmZvEhgKEHNob3BfZ29vZHNf";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 3) = "cHJpY2UYASABKA0SEwoLaXNfc29sZF9vdXQYDCABKAgSOQoSc3BlY2lhbF9n";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 4) = "b29kc19pbmZvGNwJIAEoCzIaLkdyaWRGaWdodFNwZWNpYWxHb29kc0luZm9I";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 5) = "ABIzCg9yb2xlX2dvb2RzX2luZm8YkwsgASgLMhcuR3JpZEZpZ2h0Um9sZUdv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 6) = "b2RzSW5mb0gAQg0KC0ZMQkNNQUNQSE1KQhaqAhNNYXJjaDd0aEhvbmV5LlBy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 7) = "b3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray8<string>, string>(in buffer, 8))), new FileDescriptor[2]
		{
			GridFightRoleGoodsInfoReflection.Descriptor,
			GridFightSpecialGoodsInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightShopGoodsInfo), GridFightShopGoodsInfo.Parser, new string[4] { "ShopGoodsPrice", "IsSoldOut", "SpecialGoodsInfo", "RoleGoodsInfo" }, new string[1] { "FLBCMACPHMJ" }, null, null, null)
		}));
	}
}
