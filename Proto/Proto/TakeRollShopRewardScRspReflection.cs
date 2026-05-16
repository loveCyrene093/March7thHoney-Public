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
		buffer[0] = "Ch1UYWtlUm9sbFNob3BSZXdhcmRTY1JzcC5wcm90bxoOSXRlbUxpc3QucHJv";
		buffer[1] = "dG8ibwoXVGFrZVJvbGxTaG9wUmV3YXJkU2NSc3ASDwoHcmV0Y29kZRgEIAEo";
		buffer[2] = "DRISCgpncm91cF90eXBlGAYgASgNEhkKBnJld2FyZBgMIAEoCzIJLkl0ZW1M";
		buffer[3] = "aXN0EhQKDHJvbGxfc2hvcF9pZBgNIAEoDUIWqgITTWFyY2g3dGhIb25leS5Q";
		buffer[4] = "cm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeRollShopRewardScRsp), TakeRollShopRewardScRsp.Parser, new string[4] { "Retcode", "GroupType", "Reward", "RollShopId" }, null, null, null, null)
		}));
	}
}
