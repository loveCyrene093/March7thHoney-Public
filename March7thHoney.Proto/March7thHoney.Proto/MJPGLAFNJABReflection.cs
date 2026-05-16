using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MJPGLAFNJABReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MJPGLAFNJABReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNSlBHTEFGTkpBQi5wcm90byINCgtNSlBHTEFGTkpBQkIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MJPGLAFNJAB), MJPGLAFNJAB.Parser, null, null, null, null, null)
		}));
	}
}
