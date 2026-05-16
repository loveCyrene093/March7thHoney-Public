using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LobbyInteractScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LobbyInteractScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtMb2JieUludGVyYWN0U2NOb3RpZnkucHJvdG8aF0xvYmJ5SW50ZXJhY3RU" + "eXBlLnByb3RvIlUKFUxvYmJ5SW50ZXJhY3RTY05vdGlmeRInCgtIR0lBR0pN" + "SERPQhgEIAEoDjISLkxvYmJ5SW50ZXJhY3RUeXBlEhMKC0FPTkdPRUFGS09D" + "GAUgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { LobbyInteractTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LobbyInteractScNotify), LobbyInteractScNotify.Parser, new string[2] { "HGIAGJMHDOB", "AONGOEAFKOC" }, null, null, null, null)
		}));
	}
}
