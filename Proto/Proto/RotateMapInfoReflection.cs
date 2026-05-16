using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RotateMapInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RotateMapInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChNSb3RhdGVNYXBJbmZvLnByb3RvGgxWZWN0b3IucHJvdG8aDVZlY3RvcjQu" + "cHJvdG8iTAoNUm90YXRlTWFwSW5mbxIdCgtKT0dCSklCRUVFQhgIIAEoCzII" + "LlZlY3RvcjQSHAoLTEdLTUVQT0pBQ0kYCyABKAsyBy5WZWN0b3JCFqoCE01h" + "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[2]
		{
			VectorReflection.Descriptor,
			Vector4Reflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RotateMapInfo), RotateMapInfo.Parser, new string[2] { "JOGBJIBEEEB", "LGKMEPOJACI" }, null, null, null, null)
		}));
	}
}
