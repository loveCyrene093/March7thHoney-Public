using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChimeraDuelStartGameCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChimeraDuelStartGameCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9DaGltZXJhRHVlbFN0YXJ0R2FtZUNzUmVxLnByb3RvIjAKGUNoaW1lcmFE" + "dWVsU3RhcnRHYW1lQ3NSZXESEwoLT0ZGSURNRUpCR0kYDiABKA1CFqoCE01h" + "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChimeraDuelStartGameCsReq), ChimeraDuelStartGameCsReq.Parser, new string[1] { "OFFIDMEJBGI" }, null, null, null, null)
		}));
	}
}
