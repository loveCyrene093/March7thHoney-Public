using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DDFPFLMIFKMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DDFPFLMIFKMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFEREZQRkxNSUZLTS5wcm90byINCgtEREZQRkxNSUZLTUIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DDFPFLMIFKM), DDFPFLMIFKM.Parser, null, null, null, null, null)
		}));
	}
}
