using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightAugmentActionResultReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightAugmentActionResultReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJHcmlkRmlnaHRBdWdtZW50QWN0aW9uUmVzdWx0LnByb3RvIjIKHEdyaWRG" + "aWdodEF1Z21lbnRBY3Rpb25SZXN1bHQSEgoKYXVnbWVudF9pZBgOIAEoDUIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightAugmentActionResult), GridFightAugmentActionResult.Parser, new string[1] { "AugmentId" }, null, null, null, null)
		}));
	}
}
