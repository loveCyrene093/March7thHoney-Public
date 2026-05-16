using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BuffInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BuffInfoReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "Cg5CdWZmSW5mby5wcm90byKEAgoIQnVmZkluZm8SDQoFY291bnQYAiABKA0S";
		buffer[1] = "DwoHYnVmZl9pZBgEIAEoDRITCgthZGRfdGltZV9tcxgGIAEoBBINCgVsZXZl";
		buffer[2] = "bBgJIAEoDRI0Cg5keW5hbWljX3ZhbHVlcxgKIAMoCzIcLkJ1ZmZJbmZvLkR5";
		buffer[3] = "bmFtaWNWYWx1ZXNFbnRyeRIdChVidWZmX3N1bW1vbl9lbnRpdHlfaWQYDSAB";
		buffer[4] = "KA0SEQoJbGlmZV90aW1lGA4gASgCEhYKDmJhc2VfYXZhdGFyX2lkGA8gASgN";
		buffer[5] = "GjQKEkR5bmFtaWNWYWx1ZXNFbnRyeRILCgNrZXkYASABKAkSDQoFdmFsdWUY";
		buffer[6] = "AiABKAI6AjgBQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BuffInfo), BuffInfo.Parser, new string[8] { "Count", "BuffId", "AddTimeMs", "Level", "DynamicValues", "BuffSummonEntityId", "LifeTime", "BaseAvatarId" }, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
