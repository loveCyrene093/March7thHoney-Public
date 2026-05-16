using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MHJNBBPBLBOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MHJNBBPBLBOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNSEpOQkJQQkxCTy5wcm90bxoQQXZhdGFyVHlwZS5wcm90byJCCgtNSEpO" + "QkJQQkxCTxIgCgthdmF0YXJfdHlwZRgLIAEoDjILLkF2YXRhclR5cGUSEQoJ" + "YXZhdGFyX2lkGA4gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[1] { AvatarTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MHJNBBPBLBO), MHJNBBPBLBO.Parser, new string[2] { "AvatarType", "AvatarId" }, null, null, null, null)
		}));
	}
}
