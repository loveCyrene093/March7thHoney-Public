using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetAiPamChatHistoryCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetAiPamChatHistoryCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5HZXRBaVBhbUNoYXRIaXN0b3J5Q3NSZXEucHJvdG8iLwoYR2V0QWlQYW1D" + "aGF0SGlzdG9yeUNzUmVxEhMKC3RhcmdldF9zaWRlGAIgASgNQhaqAhNNYXJj" + "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetAiPamChatHistoryCsReq), GetAiPamChatHistoryCsReq.Parser, new string[1] { "TargetSide" }, null, null, null, null)
		}));
	}
}
