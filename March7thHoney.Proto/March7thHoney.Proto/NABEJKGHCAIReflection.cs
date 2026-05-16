using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NABEJKGHCAIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NABEJKGHCAIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOQUJFSktHSENBSS5wcm90bxoRRkhDQ0NISkhIS0wucHJvdG8iKwoLTkFC" + "RUpLR0hDQUkSHAoGbGluZXVwGAEgASgLMgwuRkhDQ0NISkhIS0xCFqoCE01h" + "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { FHCCCHJHHKLReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NABEJKGHCAI), NABEJKGHCAI.Parser, new string[1] { "Lineup" }, null, null, null, null)
		}));
	}
}
