using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ECGEFDKBCCBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ECGEFDKBCCBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFQ0dFRkRLQkNDQi5wcm90byINCgtFQ0dFRkRLQkNDQkIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ECGEFDKBCCB), ECGEFDKBCCB.Parser, null, null, null, null, null)
		}));
	}
}
