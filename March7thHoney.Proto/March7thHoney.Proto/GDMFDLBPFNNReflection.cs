using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GDMFDLBPFNNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GDMFDLBPFNNReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHRE1GRExCUEZOTi5wcm90byINCgtHRE1GRExCUEZOTkIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GDMFDLBPFNN), GDMFDLBPFNN.Parser, null, null, null, null, null)
		}));
	}
}
