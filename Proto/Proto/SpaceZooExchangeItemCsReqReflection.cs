using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SpaceZooExchangeItemCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SpaceZooExchangeItemCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9TcGFjZVpvb0V4Y2hhbmdlSXRlbUNzUmVxLnByb3RvIiwKGVNwYWNlWm9v" + "RXhjaGFuZ2VJdGVtQ3NSZXESDwoHaXRlbV9pZBgMIAEoDUIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SpaceZooExchangeItemCsReq), SpaceZooExchangeItemCsReq.Parser, new string[1] { "ItemId" }, null, null, null, null)
		}));
	}
}
