using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NewSupplementVisitorCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NewSupplementVisitorCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9OZXdTdXBwbGVtZW50VmlzaXRvckNzUmVxLnByb3RvIjAKGU5ld1N1cHBs" + "ZW1lbnRWaXNpdG9yQ3NSZXESEwoLR0xCUExKUFBKUEEYBiADKA1CFqoCE01h" + "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NewSupplementVisitorCsReq), NewSupplementVisitorCsReq.Parser, new string[1] { "GLBPLJPPJPA" }, null, null, null, null)
		}));
	}
}
