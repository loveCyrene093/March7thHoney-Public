using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KNDCLJNMAOCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KNDCLJNMAOCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLTkRDTEpOTUFPQy5wcm90byINCgtLTkRDTEpOTUFPQ0IWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KNDCLJNMAOC), KNDCLJNMAOC.Parser, null, null, null, null, null)
		}));
	}
}
