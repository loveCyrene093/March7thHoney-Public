using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeAssistRewardCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeAssistRewardCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtUYWtlQXNzaXN0UmV3YXJkQ3NSZXEucHJvdG8iFwoVVGFrZUFzc2lzdFJl" + "d2FyZENzUmVxQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeAssistRewardCsReq), TakeAssistRewardCsReq.Parser, null, null, null, null, null)
		}));
	}
}
