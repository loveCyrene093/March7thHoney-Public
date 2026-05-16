using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KIDALMMDIEFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KIDALMMDIEFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLSURBTE1NRElFRi5wcm90byINCgtLSURBTE1NRElFRkIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KIDALMMDIEF), KIDALMMDIEF.Parser, null, null, null, null, null)
		}));
	}
}
