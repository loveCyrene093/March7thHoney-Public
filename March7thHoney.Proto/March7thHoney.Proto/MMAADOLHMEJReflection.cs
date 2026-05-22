using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MMAADOLHMEJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MMAADOLHMEJReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNTUFBRE9MSE1FSi5wcm90bxoQQXZhdGFyVHlwZS5wcm90byJCCgtNTUFB" + "RE9MSE1FShIRCglhdmF0YXJfaWQYAiABKA0SIAoLYXZhdGFyX3R5cGUYDSAB" + "KA4yCy5BdmF0YXJUeXBlQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[1] { AvatarTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MMAADOLHMEJ), MMAADOLHMEJ.Parser, new string[2] { "AvatarId", "AvatarType" }, null, null, null, null)
		}));
	}
}
