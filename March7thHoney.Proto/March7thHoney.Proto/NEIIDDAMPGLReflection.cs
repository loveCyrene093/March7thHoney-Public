using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NEIIDDAMPGLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NEIIDDAMPGLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFORUlJRERBTVBHTC5wcm90bxoRSExET05MSUNOT0IucHJvdG8aEUpBTUxI" + "T0hCSUdCLnByb3RvIlMKC05FSUlEREFNUEdMEiEKC0dHT0tIT0JCSEhGGAQg" + "ASgOMgwuSExET05MSUNOT0ISIQoLUElNQUhHRkRHQ0QYCCABKAsyDC5KQU1M" + "SE9IQklHQkIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[2]
		{
			HLDONLICNOBReflection.Descriptor,
			JAMLHOHBIGBReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NEIIDDAMPGL), NEIIDDAMPGL.Parser, new string[2] { "GGOKHOBBHHF", "PIMAHGFDGCD" }, null, null, null, null)
		}));
	}
}
