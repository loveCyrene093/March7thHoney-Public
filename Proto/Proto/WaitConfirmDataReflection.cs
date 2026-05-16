using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class WaitConfirmDataReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static WaitConfirmDataReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVXYWl0Q29uZmlybURhdGEucHJvdG8ibgoPV2FpdENvbmZpcm1EYXRhEg8K" + "B3BlYWtfaWQYASABKA0SFwoPaXNfd2FpdF9jb25maXJtGAUgASgIEhwKFGZp" + "bmlzaGVkX3RhcmdldF9saXN0GAkgAygNEhMKC2N5Y2xlc191c2VkGAwgASgN" + "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(WaitConfirmData), WaitConfirmData.Parser, new string[4] { "PeakId", "IsWaitConfirm", "FinishedTargetList", "CyclesUsed" }, null, null, null, null)
		}));
	}
}
