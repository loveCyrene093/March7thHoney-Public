using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeRogueEndlessActivityPointRewardScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeRogueEndlessActivityPointRewardScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "Ci5UYWtlUm9ndWVFbmRsZXNzQWN0aXZpdHlQb2ludFJld2FyZFNjUnNwLnBy";
		buffer[1] = "b3RvGg5JdGVtTGlzdC5wcm90byKkAQooVGFrZVJvZ3VlRW5kbGVzc0FjdGl2";
		buffer[2] = "aXR5UG9pbnRSZXdhcmRTY1JzcBIZCgZyZXdhcmQYASABKAsyCS5JdGVtTGlz";
		buffer[3] = "dBITCgtPSU5NRU5GUE9EUBgCIAEoCBITCgtOQUdMSkRDTEdHQhgEIAEoDRIP";
		buffer[4] = "CgdyZXRjb2RlGAUgASgNEhMKC01PR0JOSk9IS0xBGAkgAygNEg0KBWxldmVs";
		buffer[5] = "GA0gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeRogueEndlessActivityPointRewardScRsp), TakeRogueEndlessActivityPointRewardScRsp.Parser, new string[6] { "Reward", "OINMENFPODP", "NAGLJDCLGGB", "Retcode", "MOGBNJOHKLA", "Level" }, null, null, null, null)
		}));
	}
}
