using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeAssistRewardScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeAssistRewardScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChtUYWtlQXNzaXN0UmV3YXJkU2NSc3AucHJvdG8aDkl0ZW1MaXN0LnByb3Rv";
		buffer[1] = "GhFNQklDQktBRkdJSy5wcm90byJmChVUYWtlQXNzaXN0UmV3YXJkU2NSc3AS";
		buffer[2] = "DwoHcmV0Y29kZRgGIAEoDRIhCgtDQURQSk1BTlBDQRgJIAMoCzIMLk1CSUNC";
		buffer[3] = "S0FGR0lLEhkKBnJld2FyZBgKIAEoCzIJLkl0ZW1MaXN0QhaqAhNNYXJjaDd0";
		buffer[4] = "aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			ItemListReflection.Descriptor,
			MBICBKAFGIKReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeAssistRewardScRsp), TakeAssistRewardScRsp.Parser, new string[3] { "Retcode", "CADPJMANPCA", "Reward" }, null, null, null, null)
		}));
	}
}
