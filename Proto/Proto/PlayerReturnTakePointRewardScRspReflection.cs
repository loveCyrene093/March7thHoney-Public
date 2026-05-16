using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlayerReturnTakePointRewardScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlayerReturnTakePointRewardScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiZQbGF5ZXJSZXR1cm5UYWtlUG9pbnRSZXdhcmRTY1JzcC5wcm90bxoOSXRl";
		buffer[1] = "bUxpc3QucHJvdG8ifQogUGxheWVyUmV0dXJuVGFrZVBvaW50UmV3YXJkU2NS";
		buffer[2] = "c3ASHgoLQkdQS1BLSENHS0UYASABKAsyCS5JdGVtTGlzdBITCgtFRElHSkdH";
		buffer[3] = "UFBPThgDIAEoDRIPCgdyZXRjb2RlGAQgASgNEhMKC0hEQUJNS0NOSkpLGAkg";
		buffer[4] = "ASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlayerReturnTakePointRewardScRsp), PlayerReturnTakePointRewardScRsp.Parser, new string[4] { "BGPKPKHCGKE", "EDIGJGGPPON", "Retcode", "HDABMKCNJJK" }, null, null, null, null)
		}));
	}
}
