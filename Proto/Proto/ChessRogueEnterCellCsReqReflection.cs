using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChessRogueEnterCellCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChessRogueEnterCellCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5DaGVzc1JvZ3VlRW50ZXJDZWxsQ3NSZXEucHJvdG8iRAoYQ2hlc3NSb2d1" + "ZUVudGVyQ2VsbENzUmVxEhMKC0VJSUFHQUJBRkVDGAkgASgNEhMKC0pOTE5N" + "SE9PRUtMGA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueEnterCellCsReq), ChessRogueEnterCellCsReq.Parser, new string[2] { "EIIAGABAFEC", "JNLNMHOOEKL" }, null, null, null, null)
		}));
	}
}
