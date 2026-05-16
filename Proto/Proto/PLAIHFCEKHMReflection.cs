using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PLAIHFCEKHMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PLAIHFCEKHMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQTEFJSEZDRUtITS5wcm90byINCgtQTEFJSEZDRUtITUIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PLAIHFCEKHM), PLAIHFCEKHM.Parser, null, null, null, null, null)
		}));
	}
}
