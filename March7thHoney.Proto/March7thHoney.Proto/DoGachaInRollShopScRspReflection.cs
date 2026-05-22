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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChxEb0dhY2hhSW5Sb2xsU2hvcFNjUnNwLnByb3RvGg5JdGVtTGlzdC5wcm90";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "byKMAQoWRG9HYWNoYUluUm9sbFNob3BTY1JzcBIPCgdyZXRjb2RlGAcgASgN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "EhMKC05KSktJQ05PRkNMGAsgASgNEhkKBnJld2FyZBgNIAEoCzIJLkl0ZW1M";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "aXN0EhsKE3Jld2FyZF9kaXNwbGF5X3R5cGUYDiABKA0SFAoMcm9sbF9zaG9w";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "X2lkGA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DoGachaInRollShopScRsp), DoGachaInRollShopScRsp.Parser, new string[5] { "Retcode", "NJJKICNOFCL", "Reward", "RewardDisplayType", "RollShopId" }, null, null, null, null)
		}));
	}
}
