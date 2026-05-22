using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FOHHEPOECMLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FOHHEPOECMLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGT0hIRVBPRUNNTC5wcm90byINCgtGT0hIRVBPRUNNTEIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FOHHEPOECML), FOHHEPOECML.Parser, null, null, null, null, null)
		}));
	}
}
