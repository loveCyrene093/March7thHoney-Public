using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FNGPALCMBKKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FNGPALCMBKKReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGTkdQQUxDTUJLSy5wcm90bxoQQXZhdGFyVHlwZS5wcm90byJCCgtGTkdQ" + "QUxDTUJLSxIgCgthdmF0YXJfdHlwZRgHIAEoDjILLkF2YXRhclR5cGUSEQoJ" + "YXZhdGFyX2lkGAkgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[1] { AvatarTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FNGPALCMBKK), FNGPALCMBKK.Parser, new string[2] { "AvatarType", "AvatarId" }, null, null, null, null)
		}));
	}
}
