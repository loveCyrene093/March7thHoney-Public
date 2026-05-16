using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MarbleUnlockSealScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MarbleUnlockSealScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5NYXJibGVVbmxvY2tTZWFsU2NOb3RpZnkucHJvdG8iLwoYTWFyYmxlVW5s" + "b2NrU2VhbFNjTm90aWZ5EhMKC05MT0lOTU9EQkxFGA0gAygNQhaqAhNNYXJj" + "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MarbleUnlockSealScNotify), MarbleUnlockSealScNotify.Parser, new string[1] { "NLOINMODBLE" }, null, null, null, null)
		}));
	}
}
