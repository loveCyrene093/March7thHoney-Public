using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeRollShopRewardScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeRollShopRewardScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "Ch1UYWtlUm9sbFNob3BSZXdhcmRTY1JzcC5wcm90bxoOSXRlbUxpc3QucHJv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "dG8ibwoXVGFrZVJvbGxTaG9wUmV3YXJkU2NSc3ASDwoHcmV0Y29kZRgEIAEo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "DRISCgpncm91cF90eXBlGAYgASgNEhkKBnJld2FyZBgMIAEoCzIJLkl0ZW1M";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "aXN0EhQKDHJvbGxfc2hvcF9pZBgNIAEoDUIWqgITTWFyY2g3dGhIb25leS5Q";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "cm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeRollShopRewardScRsp), TakeRollShopRewardScRsp.Parser, new string[4] { "Retcode", "GroupType", "Reward", "RollShopId" }, null, null, null, null)
		}));
	}
}
