using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeRogueEndlessActivityAllBonusRewardScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeRogueEndlessActivityAllBonusRewardScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "CjFUYWtlUm9ndWVFbmRsZXNzQWN0aXZpdHlBbGxCb251c1Jld2FyZFNjUnNw";
		buffer[1] = "LnByb3RvGg5JdGVtTGlzdC5wcm90byKDAQorVGFrZVJvZ3VlRW5kbGVzc0Fj";
		buffer[2] = "dGl2aXR5QWxsQm9udXNSZXdhcmRTY1JzcBITCgtNT0dCTkpPSEtMQRgDIAMo";
		buffer[3] = "DRIZCgZyZXdhcmQYBSABKAsyCS5JdGVtTGlzdBITCgtOQUdMSkRDTEdHQhgH";
		buffer[4] = "IAEoDRIPCgdyZXRjb2RlGA0gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv";
		buffer[5] = "YgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeRogueEndlessActivityAllBonusRewardScRsp), TakeRogueEndlessActivityAllBonusRewardScRsp.Parser, new string[4] { "MOGBNJOHKLA", "Reward", "NAGLJDCLGGB", "Retcode" }, null, null, null, null)
		}));
	}
}
