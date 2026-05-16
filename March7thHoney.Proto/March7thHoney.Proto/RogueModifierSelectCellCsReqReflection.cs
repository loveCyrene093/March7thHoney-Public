using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueModifierSelectCellCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueModifierSelectCellCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJSb2d1ZU1vZGlmaWVyU2VsZWN0Q2VsbENzUmVxLnByb3RvIjMKHFJvZ3Vl" + "TW9kaWZpZXJTZWxlY3RDZWxsQ3NSZXESEwoLRUlJQUdBQkFGRUMYCCABKA1C" + "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueModifierSelectCellCsReq), RogueModifierSelectCellCsReq.Parser, new string[1] { "EIIAGABAFEC" }, null, null, null, null)
		}));
	}
}
