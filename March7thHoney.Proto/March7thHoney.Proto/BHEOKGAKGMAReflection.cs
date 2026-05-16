using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BHEOKGAKGMAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BHEOKGAKGMAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCSEVPS0dBS0dNQS5wcm90byINCgtCSEVPS0dBS0dNQUIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BHEOKGAKGMA), BHEOKGAKGMA.Parser, null, null, null, null, null)
		}));
	}
}
