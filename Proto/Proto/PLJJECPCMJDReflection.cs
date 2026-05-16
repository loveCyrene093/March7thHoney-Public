using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PLJJECPCMJDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PLJJECPCMJDReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFQTEpKRUNQQ01KRC5wcm90bxoZQ2hhbGxlbmdlTGluZXVwTGlzdC5wcm90";
		buffer[1] = "byKSAQoLUExKSkVDUENNSkQSKQoLbGluZXVwX2xpc3QYASADKAsyFC5DaGFs";
		buffer[2] = "bGVuZ2VMaW5ldXBMaXN0EhAKCGJ1ZmZfb25lGAIgASgNEhAKCHNjb3JlX2lk";
		buffer[3] = "GAcgASgNEhMKC0FCSkdOQkpNSkpHGAkgASgNEg0KBWxldmVsGAogASgNEhAK";
		buffer[4] = "CGJ1ZmZfdHdvGA0gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90";
		buffer[5] = "bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ChallengeLineupListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PLJJECPCMJD), PLJJECPCMJD.Parser, new string[6] { "LineupList", "BuffOne", "ScoreId", "ABJGNBJMJJG", "Level", "BuffTwo" }, null, null, null, null)
		}));
	}
}
