using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeRogueScoreRewardScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeRogueScoreRewardScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "Ch9UYWtlUm9ndWVTY29yZVJld2FyZFNjUnNwLnByb3RvGhFCR0tJTkNGR0tH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "SS5wcm90bxoOSXRlbUxpc3QucHJvdG8ifwoZVGFrZVJvZ3VlU2NvcmVSZXdh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "cmRTY1JzcBIPCgdyZXRjb2RlGAIgASgNEhkKBnJld2FyZBgEIAEoCzIJLkl0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "ZW1MaXN0EiEKC0FIQkZBQU1OS05PGAYgASgLMgwuQkdLSU5DRkdLR0kSEwoL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "TUJNSUNDSkVCSkIYByABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "b3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[2]
		{
			BGKINCFGKGIReflection.Descriptor,
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeRogueScoreRewardScRsp), TakeRogueScoreRewardScRsp.Parser, new string[4] { "Retcode", "Reward", "AHBFAAMNKNO", "MBMICCJEBJB" }, null, null, null, null)
		}));
	}
}
