using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EEJAJMNKAMIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EEJAJMNKAMIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFRUpBSk1OS0FNSS5wcm90byINCgtFRUpBSk1OS0FNSUIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EEJAJMNKAMI), EEJAJMNKAMI.Parser, null, null, null, null, null)
		}));
	}
}
