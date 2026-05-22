using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FCIMCHDEPPJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FCIMCHDEPPJReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGQ0lNQ0hERVBQSi5wcm90bxoQQXZhdGFyVHlwZS5wcm90byJCCgtGQ0lN" + "Q0hERVBQShIgCgthdmF0YXJfdHlwZRgLIAEoDjILLkF2YXRhclR5cGUSEQoJ" + "YXZhdGFyX2lkGAwgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[1] { AvatarTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FCIMCHDEPPJ), FCIMCHDEPPJ.Parser, new string[2] { "AvatarType", "AvatarId" }, null, null, null, null)
		}));
	}
}
