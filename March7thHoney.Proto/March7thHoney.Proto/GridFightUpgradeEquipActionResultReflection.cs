using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightUpgradeEquipActionResultReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightUpgradeEquipActionResultReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CidHcmlkRmlnaHRVcGdyYWRlRXF1aXBBY3Rpb25SZXN1bHQucHJvdG8iQAoh" + "R3JpZEZpZ2h0VXBncmFkZUVxdWlwQWN0aW9uUmVzdWx0EhsKE3NlbGVjdF9l" + "cXVpcG1lbnRfaWQYDyABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy" + "b3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightUpgradeEquipActionResult), GridFightUpgradeEquipActionResult.Parser, new string[1] { "SelectEquipmentId" }, null, null, null, null)
		}));
	}
}
