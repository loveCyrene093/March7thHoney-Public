using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueTournTakeExpRewardScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueTournTakeExpRewardScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CiJSb2d1ZVRvdXJuVGFrZUV4cFJld2FyZFNjUnNwLnByb3RvGg5JdGVtTGlz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "dC5wcm90byJsChxSb2d1ZVRvdXJuVGFrZUV4cFJld2FyZFNjUnNwEg8KB3Jl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "dGNvZGUYBCABKA0SEwoLRUlMTE9IT0lPTUUYBSADKA0SCwoDZXhwGAcgASgN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "EhkKBnJld2FyZBgIIAEoCzIJLkl0ZW1MaXN0QhaqAhNNYXJjaDd0aEhvbmV5";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournTakeExpRewardScRsp), RogueTournTakeExpRewardScRsp.Parser, new string[4] { "Retcode", "EILLOHOIOME", "Exp", "Reward" }, null, null, null, null)
		}));
	}
}
