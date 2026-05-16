using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChessRogueReRollDiceCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChessRogueReRollDiceCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9DaGVzc1JvZ3VlUmVSb2xsRGljZUNzUmVxLnByb3RvIjAKGUNoZXNzUm9n" + "dWVSZVJvbGxEaWNlQ3NSZXESEwoLQkdQQklNRENCQkwYBCABKA1CFqoCE01h" + "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueReRollDiceCsReq), ChessRogueReRollDiceCsReq.Parser, new string[1] { "BGPBIMDCBBL" }, null, null, null, null)
		}));
	}
}
