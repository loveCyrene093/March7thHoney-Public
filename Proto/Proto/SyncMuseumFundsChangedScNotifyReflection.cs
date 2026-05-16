using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SyncMuseumFundsChangedScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SyncMuseumFundsChangedScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRTeW5jTXVzZXVtRnVuZHNDaGFuZ2VkU2NOb3RpZnkucHJvdG8iMgoeU3lu" + "Y011c2V1bUZ1bmRzQ2hhbmdlZFNjTm90aWZ5EhAKCGN1cl9mdW5kGAggASgN" + "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SyncMuseumFundsChangedScNotify), SyncMuseumFundsChangedScNotify.Parser, new string[1] { "CurFund" }, null, null, null, null)
		}));
	}
}
