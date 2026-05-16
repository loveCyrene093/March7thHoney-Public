using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DLCOIEIDPKBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DLCOIEIDPKBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFETENPSUVJRFBLQi5wcm90byINCgtETENPSUVJRFBLQkIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DLCOIEIDPKB), DLCOIEIDPKB.Parser, null, null, null, null, null)
		}));
	}
}
