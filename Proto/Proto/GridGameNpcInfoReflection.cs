using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridGameNpcInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridGameNpcInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVHcmlkR2FtZU5wY0luZm8ucHJvdG8iXgoPR3JpZEdhbWVOcGNJbmZvEh8K" + "F3VwZGF0ZV9lcXVpcHNfY29tcG9uZW50GAIgAygNEhEKCXVuaXF1ZV9pZBgI" + "IAEoDRIKCgJpZBgKIAEoDRILCgNwb3MYDSABKA1CFqoCE01hcmNoN3RoSG9u" + "ZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridGameNpcInfo), GridGameNpcInfo.Parser, new string[4] { "UpdateEquipsComponent", "UniqueId", "Id", "Pos" }, null, null, null, null)
		}));
	}
}
