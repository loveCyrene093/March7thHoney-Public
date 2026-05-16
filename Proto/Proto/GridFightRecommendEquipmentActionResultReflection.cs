using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightRecommendEquipmentActionResultReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightRecommendEquipmentActionResultReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ci1HcmlkRmlnaHRSZWNvbW1lbmRFcXVpcG1lbnRBY3Rpb25SZXN1bHQucHJv" + "dG8iRgonR3JpZEZpZ2h0UmVjb21tZW5kRXF1aXBtZW50QWN0aW9uUmVzdWx0" + "EhsKE3NlbGVjdF9lcXVpcG1lbnRfaWQYByABKA1CFqoCE01hcmNoN3RoSG9u" + "ZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightRecommendEquipmentActionResult), GridFightRecommendEquipmentActionResult.Parser, new string[1] { "SelectEquipmentId" }, null, null, null, null)
		}));
	}
}
