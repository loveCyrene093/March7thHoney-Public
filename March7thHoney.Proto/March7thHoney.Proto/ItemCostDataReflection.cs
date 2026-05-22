using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ItemCostDataReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ItemCostDataReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChJJdGVtQ29zdERhdGEucHJvdG8aDkl0ZW1Db3N0LnByb3RvIiwKDEl0ZW1D" + "b3N0RGF0YRIcCglpdGVtX2xpc3QYDiADKAsyCS5JdGVtQ29zdEIWqgITTWFy" + "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { ItemCostReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ItemCostData), ItemCostData.Parser, new string[1] { "ItemList" }, null, null, null, null)
		}));
	}
}
