using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeActiveActivityRewardScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeActiveActivityRewardScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "CiNUYWtlQWN0aXZlQWN0aXZpdHlSZXdhcmRTY1JzcC5wcm90bxoYQWN0aXZl";
		buffer[1] = "QWN0aXZpdHlEYXRhLnByb3RvGg5JdGVtTGlzdC5wcm90byJ1Ch1UYWtlQWN0";
		buffer[2] = "aXZlQWN0aXZpdHlSZXdhcmRTY1JzcBIZCgZyZXdhcmQYBiABKAsyCS5JdGVt";
		buffer[3] = "TGlzdBIPCgdyZXRjb2RlGAogASgNEigKC01MQkxQQkxJSkNBGA8gASgLMhMu";
		buffer[4] = "QWN0aXZlQWN0aXZpdHlEYXRhQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw";
		buffer[5] = "cm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			ActiveActivityDataReflection.Descriptor,
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeActiveActivityRewardScRsp), TakeActiveActivityRewardScRsp.Parser, new string[3] { "Reward", "Retcode", "MLBLPBLIJCA" }, null, null, null, null)
		}));
	}
}
