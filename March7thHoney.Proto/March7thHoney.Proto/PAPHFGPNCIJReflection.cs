using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PAPHFGPNCIJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PAPHFGPNCIJReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQQVBIRkdQTkNJSi5wcm90byINCgtQQVBIRkdQTkNJSkIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PAPHFGPNCIJ), PAPHFGPNCIJ.Parser, null, null, null, null, null)
		}));
	}
}
