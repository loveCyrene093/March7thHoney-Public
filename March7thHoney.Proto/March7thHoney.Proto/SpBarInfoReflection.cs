using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SpBarInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SpBarInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cg9TcEJhckluZm8ucHJvdG8iKwoJU3BCYXJJbmZvEg4KBmN1cl9zcBgBIAEo" + "DRIOCgZtYXhfc3AYAiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy" + "b3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SpBarInfo), SpBarInfo.Parser, new string[2] { "CurSp", "MaxSp" }, null, null, null, null)
		}));
	}
}
