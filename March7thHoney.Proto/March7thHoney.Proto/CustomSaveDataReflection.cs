using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CustomSaveDataReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CustomSaveDataReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRDdXN0b21TYXZlRGF0YS5wcm90byI1Cg5DdXN0b21TYXZlRGF0YRIRCglz" + "YXZlX2RhdGEYCiABKAkSEAoIZ3JvdXBfaWQYDSABKA1CFqoCE01hcmNoN3Ro" + "SG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CustomSaveData), CustomSaveData.Parser, new string[2] { "SaveData", "GroupId" }, null, null, null, null)
		}));
	}
}
