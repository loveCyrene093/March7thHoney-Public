using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ILNEBPJCGHBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ILNEBPJCGHBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJTE5FQlBKQ0dIQi5wcm90bxoQQXZhdGFyVHlwZS5wcm90byJCCgtJTE5F" + "QlBKQ0dIQhIgCgthdmF0YXJfdHlwZRgMIAEoDjILLkF2YXRhclR5cGUSEQoJ" + "YXZhdGFyX2lkGA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[1] { AvatarTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ILNEBPJCGHB), ILNEBPJCGHB.Parser, new string[2] { "AvatarType", "AvatarId" }, null, null, null, null)
		}));
	}
}
