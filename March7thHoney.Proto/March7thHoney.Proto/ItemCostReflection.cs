using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ItemCostReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ItemCostReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Cg5JdGVtQ29zdC5wcm90bxoOUGlsZUl0ZW0ucHJvdG8ibAoISXRlbUNvc3QS" + "HQoTZXF1aXBtZW50X3VuaXF1ZV9pZBgIIAEoDUgAEh4KCXBpbGVfaXRlbRgL" + "IAEoCzIJLlBpbGVJdGVtSAASGQoPcmVsaWNfdW5pcXVlX2lkGA0gASgNSABC" + "BgoEaXRlbUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { PileItemReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ItemCost), ItemCost.Parser, new string[3] { "EquipmentUniqueId", "PileItem", "RelicUniqueId" }, new string[1] { "Item" }, null, null, null)
		}));
	}
}
