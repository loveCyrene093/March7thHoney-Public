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
		buffer[0] = "CipGaW5pc2hGaXJzdFRhbGtCeVBlcmZvcm1hbmNlTnBjU2NSc3AucHJvdG8a";
		buffer[1] = "Dkl0ZW1MaXN0LnByb3RvImoKJEZpbmlzaEZpcnN0VGFsa0J5UGVyZm9ybWFu";
		buffer[2] = "Y2VOcGNTY1JzcBIWCg5wZXJmb3JtYW5jZV9pZBgBIAEoDRIPCgdyZXRjb2Rl";
		buffer[3] = "GAQgASgNEhkKBnJld2FyZBgKIAEoCzIJLkl0ZW1MaXN0QhaqAhNNYXJjaDd0";
		buffer[4] = "aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FinishFirstTalkByPerformanceNpcScRsp), FinishFirstTalkByPerformanceNpcScRsp.Parser, new string[3] { "PerformanceId", "Retcode", "Reward" }, null, null, null, null)
		}));
	}
}
