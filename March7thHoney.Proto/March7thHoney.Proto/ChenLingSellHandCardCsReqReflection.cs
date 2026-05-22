using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChenLingSellHandCardCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChenLingSellHandCardCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9DaGVuTGluZ1NlbGxIYW5kQ2FyZENzUmVxLnByb3RvIjAKGUNoZW5MaW5n" + "U2VsbEhhbmRDYXJkQ3NSZXESEwoLR0RGUEJITU1GRUEYCiABKA1CFqoCE01h" + "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChenLingSellHandCardCsReq), ChenLingSellHandCardCsReq.Parser, new string[1] { "GDFPBHMMFEA" }, null, null, null, null)
		}));
	}
}
