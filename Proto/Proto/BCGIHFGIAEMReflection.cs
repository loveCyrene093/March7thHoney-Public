using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BCGIHFGIAEMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BCGIHFGIAEMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCQ0dJSEZHSUFFTS5wcm90byIZCgtCQ0dJSEZHSUFFTRIKCgJpZBgCIAEo" + "DUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BCGIHFGIAEM), BCGIHFGIAEM.Parser, new string[1] { "Id" }, null, null, null, null)
		}));
	}
}
