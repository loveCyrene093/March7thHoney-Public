using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FDOEMKPGHFLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FDOEMKPGHFLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGRE9FTUtQR0hGTC5wcm90byIjCgtGRE9FTUtQR0hGTBIJCgF4GAcgASgF" + "EgkKAXkYDSABKAVCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FDOEMKPGHFL), FDOEMKPGHFL.Parser, new string[2] { "X", "Y" }, null, null, null, null)
		}));
	}
}
