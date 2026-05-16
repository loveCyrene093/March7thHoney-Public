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
		buffer[0] = "CiJSb2d1ZVRvdXJuVGFrZUV4cFJld2FyZFNjUnNwLnByb3RvGg5JdGVtTGlz";
		buffer[1] = "dC5wcm90byJsChxSb2d1ZVRvdXJuVGFrZUV4cFJld2FyZFNjUnNwEg8KB3Jl";
		buffer[2] = "dGNvZGUYBCABKA0SEwoLRUlMTE9IT0lPTUUYBSADKA0SCwoDZXhwGAcgASgN";
		buffer[3] = "EhkKBnJld2FyZBgIIAEoCzIJLkl0ZW1MaXN0QhaqAhNNYXJjaDd0aEhvbmV5";
		buffer[4] = "LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournTakeExpRewardScRsp), RogueTournTakeExpRewardScRsp.Parser, new string[4] { "Retcode", "EILLOHOIOME", "Exp", "Reward" }, null, null, null, null)
		}));
	}
}
