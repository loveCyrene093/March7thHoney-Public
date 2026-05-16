using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ItemReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ItemReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CgpJdGVtLnByb3RvIn4KBEl0ZW0SDAoEcmFuaxgBIAEoDRINCgVsZXZlbBgD" + "IAEoDRIRCgl1bmlxdWVfaWQYBSABKA0SDwoHaXRlbV9pZBgJIAEoDRIRCglw" + "cm9tb3Rpb24YDCABKA0SCwoDbnVtGA0gASgNEhUKDW1haW5fYWZmaXhfaWQY" + "DiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(Item), Item.Parser, new string[7] { "Rank", "Level", "UniqueId", "ItemId", "Promotion", "Num", "MainAffixId" }, null, null, null, null)
		}));
	}
}
