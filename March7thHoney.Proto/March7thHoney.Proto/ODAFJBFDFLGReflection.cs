using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ODAFJBFDFLGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ODAFJBFDFLGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPREFGSkJGREZMRy5wcm90byINCgtPREFGSkJGREZMR0IWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ODAFJBFDFLG), ODAFJBFDFLG.Parser, null, null, null, null, null)
		}));
	}
}
