using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeMaterialSubmitActivityRewardScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeMaterialSubmitActivityRewardScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CitUYWtlTWF0ZXJpYWxTdWJtaXRBY3Rpdml0eVJld2FyZFNjUnNwLnByb3Rv";
		buffer[1] = "Gg5JdGVtTGlzdC5wcm90byJoCiVUYWtlTWF0ZXJpYWxTdWJtaXRBY3Rpdml0";
		buffer[2] = "eVJld2FyZFNjUnNwEhkKBnJld2FyZBgDIAEoCzIJLkl0ZW1MaXN0EhMKC0tB";
		buffer[3] = "UEdIUE5FT0VLGAYgASgNEg8KB3JldGNvZGUYByABKA1CFqoCE01hcmNoN3Ro";
		buffer[4] = "SG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeMaterialSubmitActivityRewardScRsp), TakeMaterialSubmitActivityRewardScRsp.Parser, new string[3] { "Reward", "KAPGHPNEOEK", "Retcode" }, null, null, null, null)
		}));
	}
}
