using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MonopolySelectOptionCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MonopolySelectOptionCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9Nb25vcG9seVNlbGVjdE9wdGlvbkNzUmVxLnByb3RvIkIKGU1vbm9wb2x5" + "U2VsZWN0T3B0aW9uQ3NSZXESEAoIZXZlbnRfaWQYBSABKA0SEwoLQU1BREZK" + "TkhNRkYYBiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MonopolySelectOptionCsReq), MonopolySelectOptionCsReq.Parser, new string[2] { "EventId", "AMADFJNHMFF" }, null, null, null, null)
		}));
	}
}
