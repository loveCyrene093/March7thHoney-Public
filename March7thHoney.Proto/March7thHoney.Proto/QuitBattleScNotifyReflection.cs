using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class QuitBattleScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static QuitBattleScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhRdWl0QmF0dGxlU2NOb3RpZnkucHJvdG8iFAoSUXVpdEJhdHRsZVNjTm90" + "aWZ5QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(QuitBattleScNotify), QuitBattleScNotify.Parser, null, null, null, null, null)
		}));
	}
}
