using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ExchangeRogueRewardKeyCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ExchangeRogueRewardKeyCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFFeGNoYW5nZVJvZ3VlUmV3YXJkS2V5Q3NSZXEucHJvdG8iLAobRXhjaGFu" + "Z2VSb2d1ZVJld2FyZEtleUNzUmVxEg0KBWNvdW50GAQgASgNQhaqAhNNYXJj" + "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ExchangeRogueRewardKeyCsReq), ExchangeRogueRewardKeyCsReq.Parser, new string[1] { "Count" }, null, null, null, null)
		}));
	}
}
