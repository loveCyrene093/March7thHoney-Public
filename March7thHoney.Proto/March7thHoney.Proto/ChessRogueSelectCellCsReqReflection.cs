using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChessRogueSelectCellCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChessRogueSelectCellCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9DaGVzc1JvZ3VlU2VsZWN0Q2VsbENzUmVxLnByb3RvIkUKGUNoZXNzUm9n" + "dWVTZWxlY3RDZWxsQ3NSZXESEwoLRUlJQUdBQkFGRUMYCyABKA0SEwoLSk5M" + "Tk1IT09FS0wYDCABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv" + "Mw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueSelectCellCsReq), ChessRogueSelectCellCsReq.Parser, new string[2] { "EIIAGABAFEC", "JNLNMHOOEKL" }, null, null, null, null)
		}));
	}
}
