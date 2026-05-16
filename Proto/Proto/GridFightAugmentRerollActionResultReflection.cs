using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightAugmentRerollActionResultReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightAugmentRerollActionResultReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CihHcmlkRmlnaHRBdWdtZW50UmVyb2xsQWN0aW9uUmVzdWx0LnByb3RvIjgK" + "IkdyaWRGaWdodEF1Z21lbnRSZXJvbGxBY3Rpb25SZXN1bHQSEgoKYXVnbWVu" + "dF9pZBgEIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightAugmentRerollActionResult), GridFightAugmentRerollActionResult.Parser, new string[1] { "AugmentId" }, null, null, null, null)
		}));
	}
}
