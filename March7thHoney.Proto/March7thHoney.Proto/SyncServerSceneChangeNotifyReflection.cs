using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SyncServerSceneChangeNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SyncServerSceneChangeNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFTeW5jU2VydmVyU2NlbmVDaGFuZ2VOb3RpZnkucHJvdG8iHQobU3luY1Nl" + "cnZlclNjZW5lQ2hhbmdlTm90aWZ5QhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv" + "YgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SyncServerSceneChangeNotify), SyncServerSceneChangeNotify.Parser, null, null, null, null, null)
		}));
	}
}
