using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EFLGLOKNBKPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EFLGLOKNBKPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFRkxHTE9LTkJLUC5wcm90bxoOSXRlbUxpc3QucHJvdG8iWQoLRUZMR0xP" + "S05CS1ASDQoFbGV2ZWwYAiABKA0SDwoHcmV0Y29kZRgKIAEoDRIZCgZyZXdh" + "cmQYDCABKAsyCS5JdGVtTGlzdBIPCgdzaG9wX2lkGA0gASgNQhaqAhNNYXJj" + "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EFLGLOKNBKP), EFLGLOKNBKP.Parser, new string[4] { "Level", "Retcode", "Reward", "ShopId" }, null, null, null, null)
		}));
	}
}
