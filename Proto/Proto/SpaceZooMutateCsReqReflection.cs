using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SpaceZooMutateCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SpaceZooMutateCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlTcGFjZVpvb011dGF0ZUNzUmVxLnByb3RvIjkKE1NwYWNlWm9vTXV0YXRl" + "Q3NSZXESDwoHaXRlbV9pZBgCIAEoDRIRCgl1bmlxdWVfaWQYDSABKA1CFqoC" + "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SpaceZooMutateCsReq), SpaceZooMutateCsReq.Parser, new string[2] { "ItemId", "UniqueId" }, null, null, null, null)
		}));
	}
}
