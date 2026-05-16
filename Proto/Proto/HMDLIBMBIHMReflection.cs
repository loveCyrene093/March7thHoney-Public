using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HMDLIBMBIHMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HMDLIBMBIHMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFITURMSUJNQklITS5wcm90bxoQQXZhdGFyVHlwZS5wcm90byJfCgtITURM" + "SUJNQklITRINCgVsZXZlbBgIIAEoDRIgCgthdmF0YXJfdHlwZRgLIAEoDjIL" + "LkF2YXRhclR5cGUSCgoCaWQYDiABKA0SEwoLSkxGTENEQ0dDT0wYDyABKAhC" + "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { AvatarTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HMDLIBMBIHM), HMDLIBMBIHM.Parser, new string[4] { "Level", "AvatarType", "Id", "JLFLCDCGCOL" }, null, null, null, null)
		}));
	}
}
