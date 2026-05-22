using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightReturnPreparationActionResultReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightReturnPreparationActionResultReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CixHcmlkRmlnaHRSZXR1cm5QcmVwYXJhdGlvbkFjdGlvblJlc3VsdC5wcm90" + "byIoCiZHcmlkRmlnaHRSZXR1cm5QcmVwYXJhdGlvbkFjdGlvblJlc3VsdEIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightReturnPreparationActionResult), GridFightReturnPreparationActionResult.Parser, null, null, null, null, null)
		}));
	}
}
