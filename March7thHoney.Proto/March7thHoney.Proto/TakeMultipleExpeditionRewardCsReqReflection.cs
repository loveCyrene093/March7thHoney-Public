using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeMultipleExpeditionRewardCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeMultipleExpeditionRewardCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CidUYWtlTXVsdGlwbGVFeHBlZGl0aW9uUmV3YXJkQ3NSZXEucHJvdG8iIwoh" + "VGFrZU11bHRpcGxlRXhwZWRpdGlvblJld2FyZENzUmVxQhaqAhNNYXJjaDd0" + "aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeMultipleExpeditionRewardCsReq), TakeMultipleExpeditionRewardCsReq.Parser, null, null, null, null, null)
		}));
	}
}
