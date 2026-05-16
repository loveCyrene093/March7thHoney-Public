using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FinishFirstTalkByPerformanceNpcScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FinishFirstTalkByPerformanceNpcScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CipGaW5pc2hGaXJzdFRhbGtCeVBlcmZvcm1hbmNlTnBjU2NSc3AucHJvdG8a";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "Dkl0ZW1MaXN0LnByb3RvImoKJEZpbmlzaEZpcnN0VGFsa0J5UGVyZm9ybWFu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "Y2VOcGNTY1JzcBIWCg5wZXJmb3JtYW5jZV9pZBgBIAEoDRIPCgdyZXRjb2Rl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "GAQgASgNEhkKBnJld2FyZBgKIAEoCzIJLkl0ZW1MaXN0QhaqAhNNYXJjaDd0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FinishFirstTalkByPerformanceNpcScRsp), FinishFirstTalkByPerformanceNpcScRsp.Parser, new string[3] { "PerformanceId", "Retcode", "Reward" }, null, null, null, null)
		}));
	}
}
