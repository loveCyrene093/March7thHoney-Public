using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GenderReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GenderReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CgxHZW5kZXIucHJvdG8qOAoGR2VuZGVyEg4KCkdlbmRlck5vbmUQABINCglH" + "ZW5kZXJNYW4QARIPCgtHZW5kZXJXb21hbhACQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(Gender) }, null, null));
	}
}
