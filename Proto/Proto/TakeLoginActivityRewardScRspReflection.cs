using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeLoginActivityRewardScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeLoginActivityRewardScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiJUYWtlTG9naW5BY3Rpdml0eVJld2FyZFNjUnNwLnByb3RvGg5JdGVtTGlz";
		buffer[1] = "dC5wcm90byJ7ChxUYWtlTG9naW5BY3Rpdml0eVJld2FyZFNjUnNwEg8KB3Jl";
		buffer[2] = "dGNvZGUYASABKA0SCgoCaWQYAiABKA0SEAoIcGFuZWxfaWQYBSABKA0SGQoG";
		buffer[3] = "cmV3YXJkGAcgASgLMgkuSXRlbUxpc3QSEQoJdGFrZV9kYXlzGA4gASgNQhaq";
		buffer[4] = "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeLoginActivityRewardScRsp), TakeLoginActivityRewardScRsp.Parser, new string[5] { "Retcode", "Id", "PanelId", "Reward", "TakeDays" }, null, null, null, null)
		}));
	}
}
