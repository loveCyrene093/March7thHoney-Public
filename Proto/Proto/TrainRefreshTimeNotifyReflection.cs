using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TrainRefreshTimeNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TrainRefreshTimeNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxUcmFpblJlZnJlc2hUaW1lTm90aWZ5LnByb3RvIjQKFlRyYWluUmVmcmVz" + "aFRpbWVOb3RpZnkSGgoSdHJhaW5fcmVmcmVzaF90aW1lGAMgASgEQhaqAhNN" + "YXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TrainRefreshTimeNotify), TrainRefreshTimeNotify.Parser, new string[1] { "TrainRefreshTime" }, null, null, null, null)
		}));
	}
}
