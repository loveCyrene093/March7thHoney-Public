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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CiJUYWtlQ2hhbGxlbmdlUmFpZFJld2FyZFNjUnNwLnByb3RvGg5JdGVtTGlz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "dC5wcm90byJfChxUYWtlQ2hhbGxlbmdlUmFpZFJld2FyZFNjUnNwEhkKBnJl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "d2FyZBgEIAEoCzIJLkl0ZW1MaXN0EhMKC0tJQk5MTkZQRklDGAUgASgNEg8K";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "B3JldGNvZGUYDiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "Mw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeChallengeRaidRewardScRsp), TakeChallengeRaidRewardScRsp.Parser, new string[3] { "Reward", "KIBNLNFPFIC", "Retcode" }, null, null, null, null)
		}));
	}
}
