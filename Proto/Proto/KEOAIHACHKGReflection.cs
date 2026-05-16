using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KEOAIHACHKGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KEOAIHACHKGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLRU9BSUhBQ0hLRy5wcm90byIzCgtLRU9BSUhBQ0hLRxIPCgdpdGVtX2lk" + "GA0gASgNEhMKC0xQQ1BCRUlIRk1LGA4gASgNQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KEOAIHACHKG), KEOAIHACHKG.Parser, new string[2] { "ItemId", "LPCPBEIHFMK" }, null, null, null, null)
		}));
	}
}
