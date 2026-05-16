using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class UseTreasureDungeonItemCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static UseTreasureDungeonItemCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFVc2VUcmVhc3VyZUR1bmdlb25JdGVtQ3NSZXEucHJvdG8iWAobVXNlVHJl" + "YXN1cmVEdW5nZW9uSXRlbUNzUmVxEhMKC0NKT1BORkRCSkhEGAUgASgNEg8K" + "B2l0ZW1faWQYBiABKA0SEwoLdGFyZ2V0X3NpZGUYDiABKA1CFqoCE01hcmNo" + "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(UseTreasureDungeonItemCsReq), UseTreasureDungeonItemCsReq.Parser, new string[3] { "CJOPNFDBJHD", "ItemId", "TargetSide" }, null, null, null, null)
		}));
	}
}
