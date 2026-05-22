using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class COIKCGMPJCHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static COIKCGMPJCHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDT0lLQ0dNUEpDSC5wcm90byINCgtDT0lLQ0dNUEpDSEIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(COIKCGMPJCH), COIKCGMPJCH.Parser, null, null, null, null, null)
		}));
	}
}
