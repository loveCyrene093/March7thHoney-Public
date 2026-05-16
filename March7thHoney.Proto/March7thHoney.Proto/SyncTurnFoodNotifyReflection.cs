using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SyncTurnFoodNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SyncTurnFoodNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhTeW5jVHVybkZvb2ROb3RpZnkucHJvdG8aFFR1cm5Gb29kU3dpdGNoLnBy" + "b3RvIk8KElN5bmNUdXJuRm9vZE5vdGlmeRIkCgtNQU9ETkhOSExJShgJIAMo" + "DjIPLlR1cm5Gb29kU3dpdGNoEhMKC0RCUERQSElNQkRKGA8gAygNQhaqAhNN" + "YXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { TurnFoodSwitchReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SyncTurnFoodNotify), SyncTurnFoodNotify.Parser, new string[2] { "MAODNHNHLIJ", "DBPDPHIMBDJ" }, null, null, null, null)
		}));
	}
}
