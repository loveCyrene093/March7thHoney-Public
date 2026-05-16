using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EEBPHJCNBFOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EEBPHJCNBFOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFRUJQSEpDTkJGTy5wcm90bxoQQXZhdGFyVHlwZS5wcm90byJPCgtFRUJQ" + "SEpDTkJGTxIKCgJpZBgDIAEoDRIgCgthdmF0YXJfdHlwZRgEIAEoDjILLkF2" + "YXRhclR5cGUSEgoKYXNzaXN0X3VpZBgGIAEoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { AvatarTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EEBPHJCNBFO), EEBPHJCNBFO.Parser, new string[3] { "Id", "AvatarType", "AssistUid" }, null, null, null, null)
		}));
	}
}
