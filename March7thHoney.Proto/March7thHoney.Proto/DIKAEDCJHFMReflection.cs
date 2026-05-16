using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DIKAEDCJHFMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DIKAEDCJHFMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFESUtBRURDSkhGTS5wcm90byINCgtESUtBRURDSkhGTUIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DIKAEDCJHFM), DIKAEDCJHFM.Parser, null, null, null, null, null)
		}));
	}
}
