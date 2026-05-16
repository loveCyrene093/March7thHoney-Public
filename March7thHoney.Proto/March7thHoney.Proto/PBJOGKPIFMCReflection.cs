using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PBJOGKPIFMCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PBJOGKPIFMCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQQkpPR0tQSUZNQy5wcm90byINCgtQQkpPR0tQSUZNQ0IWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PBJOGKPIFMC), PBJOGKPIFMC.Parser, null, null, null, null, null)
		}));
	}
}
