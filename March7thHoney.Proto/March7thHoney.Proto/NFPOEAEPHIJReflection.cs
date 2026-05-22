using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NFPOEAEPHIJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NFPOEAEPHIJReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFORlBPRUFFUEhJSi5wcm90byINCgtORlBPRUFFUEhJSkIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NFPOEAEPHIJ), NFPOEAEPHIJ.Parser, null, null, null, null, null)
		}));
	}
}
