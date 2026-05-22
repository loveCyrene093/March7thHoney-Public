using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MPCJEKNBPEBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MPCJEKNBPEBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNUENKRUtOQlBFQi5wcm90byINCgtNUENKRUtOQlBFQkIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MPCJEKNBPEB), MPCJEKNBPEB.Parser, null, null, null, null, null)
		}));
	}
}
