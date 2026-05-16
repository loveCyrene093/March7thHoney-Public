using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeEventHandbookRewardScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeEventHandbookRewardScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiJUYWtlRXZlbnRIYW5kYm9va1Jld2FyZFNjUnNwLnByb3RvGg5JdGVtTGlz";
		buffer[1] = "dC5wcm90byJfChxUYWtlRXZlbnRIYW5kYm9va1Jld2FyZFNjUnNwEhkKBnJl";
		buffer[2] = "d2FyZBgCIAEoCzIJLkl0ZW1MaXN0EhMKC0xLTEdCT0lET05NGAggAygNEg8K";
		buffer[3] = "B3JldGNvZGUYCyABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv";
		buffer[4] = "Mw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeEventHandbookRewardScRsp), TakeEventHandbookRewardScRsp.Parser, new string[3] { "Reward", "LKLGBOIDONM", "Retcode" }, null, null, null, null)
		}));
	}
}
