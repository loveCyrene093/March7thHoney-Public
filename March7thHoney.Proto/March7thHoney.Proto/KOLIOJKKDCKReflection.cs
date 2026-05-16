using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KOLIOJKKDCKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KOLIOJKKDCKReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLT0xJT0pLS0RDSy5wcm90byINCgtLT0xJT0pLS0RDS0IWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KOLIOJKKDCK), KOLIOJKKDCK.Parser, null, null, null, null, null)
		}));
	}
}
