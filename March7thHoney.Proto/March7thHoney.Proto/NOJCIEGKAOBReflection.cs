using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NOJCIEGKAOBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NOJCIEGKAOBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOT0pDSUVHS0FPQi5wcm90bxoQQXZhdGFyVHlwZS5wcm90byJCCgtOT0pD" + "SUVHS0FPQhIgCgthdmF0YXJfdHlwZRgMIAEoDjILLkF2YXRhclR5cGUSEQoJ" + "YXZhdGFyX2lkGA0gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[1] { AvatarTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NOJCIEGKAOB), NOJCIEGKAOB.Parser, new string[2] { "AvatarType", "AvatarId" }, null, null, null, null)
		}));
	}
}
