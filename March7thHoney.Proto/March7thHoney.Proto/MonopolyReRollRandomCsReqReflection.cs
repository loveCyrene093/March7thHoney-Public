using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MonopolyReRollRandomCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MonopolyReRollRandomCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9Nb25vcG9seVJlUm9sbFJhbmRvbUNzUmVxLnByb3RvIi0KGU1vbm9wb2x5" + "UmVSb2xsUmFuZG9tQ3NSZXESEAoIZXZlbnRfaWQYByABKA1CFqoCE01hcmNo" + "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyReRollRandomCsReq), MonopolyReRollRandomCsReq.Parser, new string[1] { "EventId" }, null, null, null, null)
		}));
	}
}
