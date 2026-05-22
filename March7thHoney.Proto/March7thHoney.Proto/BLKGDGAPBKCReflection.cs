using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BLKGDGAPBKCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BLKGDGAPBKCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCTEtHREdBUEJLQy5wcm90bxoQQXZhdGFyVHlwZS5wcm90byI7CgtCTEtH" + "REdBUEJLQxIKCgJpZBgKIAEoDRIgCgthdmF0YXJfdHlwZRgMIAEoDjILLkF2" + "YXRhclR5cGVCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { AvatarTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BLKGDGAPBKC), BLKGDGAPBKC.Parser, new string[2] { "Id", "AvatarType" }, null, null, null, null)
		}));
	}
}
