using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NLDMDNHCBNDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NLDMDNHCBNDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOTERNRE5IQ0JORC5wcm90byINCgtOTERNRE5IQ0JOREIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NLDMDNHCBND), NLDMDNHCBND.Parser, null, null, null, null, null)
		}));
	}
}
