using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlanetFesUseItemCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlanetFesUseItemCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtQbGFuZXRGZXNVc2VJdGVtQ3NSZXEucHJvdG8iPQoVUGxhbmV0RmVzVXNl" + "SXRlbUNzUmVxEhMKC09HQkRETkZFTENMGAQgASgNEg8KB2l0ZW1faWQYDyAB" + "KA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlanetFesUseItemCsReq), PlanetFesUseItemCsReq.Parser, new string[2] { "OGBDDNFELCL", "ItemId" }, null, null, null, null)
		}));
	}
}
