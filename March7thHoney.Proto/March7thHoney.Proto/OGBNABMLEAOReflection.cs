using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OGBNABMLEAOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OGBNABMLEAOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPR0JOQUJNTEVBTy5wcm90byINCgtPR0JOQUJNTEVBT0IWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OGBNABMLEAO), OGBNABMLEAO.Parser, null, null, null, null, null)
		}));
	}
}
