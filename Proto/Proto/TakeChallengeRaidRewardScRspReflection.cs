using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeChallengeRaidRewardScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeChallengeRaidRewardScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiJUYWtlQ2hhbGxlbmdlUmFpZFJld2FyZFNjUnNwLnByb3RvGg5JdGVtTGlz";
		buffer[1] = "dC5wcm90byJfChxUYWtlQ2hhbGxlbmdlUmFpZFJld2FyZFNjUnNwEhkKBnJl";
		buffer[2] = "d2FyZBgEIAEoCzIJLkl0ZW1MaXN0EhMKC0tJQk5MTkZQRklDGAUgASgNEg8K";
		buffer[3] = "B3JldGNvZGUYDiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv";
		buffer[4] = "Mw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeChallengeRaidRewardScRsp), TakeChallengeRaidRewardScRsp.Parser, new string[3] { "Reward", "KIBNLNFPFIC", "Retcode" }, null, null, null, null)
		}));
	}
}
