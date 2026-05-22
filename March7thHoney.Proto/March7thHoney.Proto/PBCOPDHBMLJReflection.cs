using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PBCOPDHBMLJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PBCOPDHBMLJReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQQkNPUERIQk1MSi5wcm90byINCgtQQkNPUERIQk1MSkIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PBCOPDHBMLJ), PBCOPDHBMLJ.Parser, null, null, null, null, null)
		}));
	}
}
