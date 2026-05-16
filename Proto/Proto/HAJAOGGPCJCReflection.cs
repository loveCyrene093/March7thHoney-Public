using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HAJAOGGPCJCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HAJAOGGPCJCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFIQUpBT0dHUENKQy5wcm90bxoQQXZhdGFyVHlwZS5wcm90byI7CgtIQUpB" + "T0dHUENKQxIgCgthdmF0YXJfdHlwZRgBIAEoDjILLkF2YXRhclR5cGUSCgoC" + "aWQYAiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { AvatarTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HAJAOGGPCJC), HAJAOGGPCJC.Parser, new string[2] { "AvatarType", "Id" }, null, null, null, null)
		}));
	}
}
