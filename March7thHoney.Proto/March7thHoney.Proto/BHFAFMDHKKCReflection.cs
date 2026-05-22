using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BHFAFMDHKKCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BHFAFMDHKKCReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChFCSEZBRk1ESEtLQy5wcm90bxoZQ2hhbGxlbmdlTGluZXVwTGlzdC5wcm90";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "byKSAQoLQkhGQUZNREhLS0MSEAoIYnVmZl90d28YAiABKA0SEAoIYnVmZl9v";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "bmUYBCABKA0SEwoLQUJKR05CSk1KSkcYCSABKA0SEAoIc2NvcmVfaWQYCyAB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "KA0SKQoLbGluZXVwX2xpc3QYDCADKAsyFC5DaGFsbGVuZ2VMaW5ldXBMaXN0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "Eg0KBWxldmVsGA0gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[1] { ChallengeLineupListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BHFAFMDHKKC), BHFAFMDHKKC.Parser, new string[6] { "BuffTwo", "BuffOne", "ABJGNBJMJJG", "ScoreId", "LineupList", "Level" }, null, null, null, null)
		}));
	}
}
