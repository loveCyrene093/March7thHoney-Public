using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HDDBJIKNEPFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HDDBJIKNEPFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFIRERCSklLTkVQRi5wcm90bxoQQXZhdGFyVHlwZS5wcm90byI7CgtIRERC" + "SklLTkVQRhIKCgJpZBgIIAEoDRIgCgthdmF0YXJfdHlwZRgPIAEoDjILLkF2" + "YXRhclR5cGVCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { AvatarTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HDDBJIKNEPF), HDDBJIKNEPF.Parser, new string[2] { "Id", "AvatarType" }, null, null, null, null)
		}));
	}
}
