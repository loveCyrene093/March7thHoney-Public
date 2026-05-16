using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MEPLFBAKEFCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MEPLFBAKEFCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNRVBMRkJBS0VGQy5wcm90byI3CgtNRVBMRkJBS0VGQxITCgtER09NSERN" + "SkhFSxgDIAMoDRITCgtPR05EQUFGSUJJRxgKIAEoCEIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MEPLFBAKEFC), MEPLFBAKEFC.Parser, new string[2] { "DGOMHDMJHEK", "OGNDAAFIBIG" }, null, null, null, null)
		}));
	}
}
