using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class VectorReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static VectorReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CgxWZWN0b3IucHJvdG8iKQoGVmVjdG9yEgkKAXgYASABKBESCQoBeRgCIAEo" + "ERIJCgF6GAMgASgRQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(Vector), Vector.Parser, new string[3] { "X", "Y", "Z" }, null, null, null, null)
		}));
	}
}
