using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MaterialReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MaterialReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cg5NYXRlcmlhbC5wcm90byI5CghNYXRlcmlhbBILCgN0aWQYCyABKA0SCwoD" + "bnVtGAwgASgNEhMKC2V4cGlyZV90aW1lGA0gASgEQhaqAhNNYXJjaDd0aEhv" + "bmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(Material), Material.Parser, new string[3] { "Tid", "Num", "ExpireTime" }, null, null, null, null)
		}));
	}
}
