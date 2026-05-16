using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeFightActivityRewardScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeFightActivityRewardScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiJUYWtlRmlnaHRBY3Rpdml0eVJld2FyZFNjUnNwLnByb3RvGg5JdGVtTGlz";
		buffer[1] = "dC5wcm90byJxChxUYWtlRmlnaHRBY3Rpdml0eVJld2FyZFNjUnNwEhkKBnJl";
		buffer[2] = "d2FyZBgEIAEoCzIJLkl0ZW1MaXN0EhAKCGdyb3VwX2lkGAkgASgNEg8KB3Jl";
		buffer[3] = "dGNvZGUYCiABKA0SEwoLSU5PTUZGQUlFT0EYDyABKA1CFqoCE01hcmNoN3Ro";
		buffer[4] = "SG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeFightActivityRewardScRsp), TakeFightActivityRewardScRsp.Parser, new string[4] { "Reward", "GroupId", "Retcode", "INOMFFAIEOA" }, null, null, null, null)
		}));
	}
}
