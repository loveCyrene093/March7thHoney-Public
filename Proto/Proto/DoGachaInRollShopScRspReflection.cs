using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DoGachaInRollShopScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DoGachaInRollShopScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChxEb0dhY2hhSW5Sb2xsU2hvcFNjUnNwLnByb3RvGg5JdGVtTGlzdC5wcm90";
		buffer[1] = "byKMAQoWRG9HYWNoYUluUm9sbFNob3BTY1JzcBIPCgdyZXRjb2RlGAcgASgN";
		buffer[2] = "EhMKC05KSktJQ05PRkNMGAsgASgNEhkKBnJld2FyZBgNIAEoCzIJLkl0ZW1M";
		buffer[3] = "aXN0EhsKE3Jld2FyZF9kaXNwbGF5X3R5cGUYDiABKA0SFAoMcm9sbF9zaG9w";
		buffer[4] = "X2lkGA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DoGachaInRollShopScRsp), DoGachaInRollShopScRsp.Parser, new string[5] { "Retcode", "NJJKICNOFCL", "Reward", "RewardDisplayType", "RollShopId" }, null, null, null, null)
		}));
	}
}
